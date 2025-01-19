using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Events.Models
{
    public class SaleCreatedEvent
    {
        public SaleCreatedEvent(string Message)
        {
            Message = Message;
        }
        public string Message { get; }
    }
}
