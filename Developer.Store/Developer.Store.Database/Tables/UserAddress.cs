using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Domain.Tables
{
    [Table("UserAddress")]
    public class UserAddress
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public required string City { get; set; }
        public required string Street { get; set; }
        public required string Number { get; set; }
        public required string Zipcode { get; set; }
        public required AddressGeolocation Geolocatio {get; set;}
            
          
}
}
