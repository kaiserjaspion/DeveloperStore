using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Domain.Request.User
{
    public class AddressGeolocationRequest
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
