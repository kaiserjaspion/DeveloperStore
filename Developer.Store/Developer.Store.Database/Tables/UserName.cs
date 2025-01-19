using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Domain.Tables
{
    [Table("UserName")]
    public class UserName
    {
        [Key]
        public int UserId { get; set; }
        public required string Firstname { get; set; }
        public required string lastname { get; set; }
    }
}
