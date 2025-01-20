using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Domain.Tables
{
    [Table("Sale")]
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Branch { get; set; }
        public bool Canceled { get; set; }
        public User User { get; set; }
        public List<SaleProduct> SaleProducts { get; set; }




    }
}
