using Developer.Store.Domain.Request.Sale;
using Developer.Store.Domain.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Domain.Response.Sale
{
    public class SaleResponse
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; }
        public string Branch { get; set; }
        public bool Canceled { get; set; }

        public UserResponse User { get; set; }
        public List<SaleProductRequest> SaleProducts { get; set; }
    }
}
