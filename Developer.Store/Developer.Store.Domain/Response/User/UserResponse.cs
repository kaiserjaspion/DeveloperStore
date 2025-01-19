using Developer.Store.Data.Domain.Enums;
using Developer.Store.Domain.Request.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Domain.Response.User
{
    public  class UserResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserNameRequest Name { get; set; }
        public UserAddressRequest Address { get; set; }
        public string Phone { get; set; }
        public UserStatus Status { get; set; }
        public UserRoles Role { get; set; }
    }
}
