using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Domain.Tables
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int Id {  get; set; }
        public required string Title { get; set; }
        public decimal Price { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public required string Image { get; set; }
        public required ProductRating Rating {  get; set; }

    }
}
