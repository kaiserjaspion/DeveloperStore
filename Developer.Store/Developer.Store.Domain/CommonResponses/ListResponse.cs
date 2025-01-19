using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Domain.CommonResponses
{
    public class ListResponse<T>
    {
        public T Data { get; set; }
        public int TotalItens { get; set; }
        public int CurrentPage { get;set; }
        public int TotalPages { get; set; }

    }
}
