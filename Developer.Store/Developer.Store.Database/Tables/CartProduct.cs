using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Developer.Store.Data.Domain.Tables
{
    [Table("CartProduct")]
    public class CartProduct
    {
        [Key]
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
