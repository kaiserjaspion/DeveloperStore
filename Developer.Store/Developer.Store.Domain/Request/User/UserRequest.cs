using Developer.Store.Data.Domain.Enums;

namespace Developer.Store.Domain.Request.User
{
    public class UserRequest 
    {
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
