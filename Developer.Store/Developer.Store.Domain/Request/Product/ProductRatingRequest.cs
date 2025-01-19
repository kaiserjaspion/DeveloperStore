using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Domain.Request.Product
{
    public class ProductRatingRequest
    {
        public decimal Rate { get; set; }
        public int Count { get; set; }
    }
}
