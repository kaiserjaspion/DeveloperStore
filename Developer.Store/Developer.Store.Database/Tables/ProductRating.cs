using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Domain.Tables
{
    [Table("ProductRating")]
    public class ProductRating
    {
        [Key]
        public int ProductId { get; set; }
        public decimal Rate{ get; set; }
        public int Count{ get; set; }
    }
}
