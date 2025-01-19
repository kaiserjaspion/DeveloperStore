using Developer.Store.Data.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Domain.Tables
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required UserName Name { get; set; }
        public required UserAddress Address { get; set; }
        public required string Phone { get; set; }
        public UserStatus Status { get; set; }
        public UserRoles Role { get; set; }
    }
}
