using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Domain.Request.Cart
{
    public class CartRequest
    {

        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public  List<CartProduct> products { get;set; }
      
      
    }
}
