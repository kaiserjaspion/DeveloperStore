using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Data.Domain.Tables
{
    [Table("SaleProduct")]
    public class SaleProduct
    {
        [Key]
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        [Range(1, 20)]
        public int Quantity {  get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount {  get; set; }
        public decimal TotalAmountItem { get;set; }
        public bool Canceled { get; set; }
    }
}
