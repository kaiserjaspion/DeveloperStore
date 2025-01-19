using AutoMapper;
using Developer.Store.Data.Contexts;
using Developer.Store.Data.Interfaces;
using Developer.Store.Domain.Reequest.Auth;
using Developer.Store.Domain.Request.User;
using Developer.Store.Domain.Response.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public UserRepository(StoreContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<UserResponse> Login(LoginRequest Login)
        {
            return _mapper.Map<UserResponse>(
                await _context.Users.Where(x => x.Username == Login.Username
                                            && x.Password == Login.Password)
                                    .FirstAsync());
        }

        public async Task<UserResponse> GetUser(int Id)
        {
            var data = await _context.Users.Where(x => x.Id == Id).FirstAsync();
            return _mapper.Map<UserResponse>(data);
        }

        public async Task<List<UserResponse>> GetUsers(int Page, int Size)
        {
            var data = await _context.Users.Skip(Page * Size).Take(Size).ToListAsync();
            return _mapper.Map<IReadOnlyList<UserResponse>>(data).ToList();
        }

        public async Task<UserResponse> RegisterUser(UserRequest User)
        {
            var UserDto = _mapper.Map<Developer.Store.Data.Domain.Tables.User>(User);
            _context.Users.Add(UserDto);
            _context.SaveChanges();
            return _mapper.Map<UserResponse>(UserDto);
        }

        public async Task<UserResponse> AlterUser(UserRequest User,int Id)
        {
            var UserDto = _mapper.Map<Developer.Store.Data.Domain.Tables.User>(User);
            UserDto.Id = Id;
            _context.Users.Update(UserDto);
            _context.SaveChanges();
            return _mapper.Map<UserResponse>(UserDto);
        }

        public async Task<UserResponse> DeleteUser(int Id)
        {
            var data = await _context.Users.Where(x => x.Id == Id).FirstAsync();
            _context.Users.Remove(data);
            return _mapper.Map<UserResponse>(data);
        }

    }
}
