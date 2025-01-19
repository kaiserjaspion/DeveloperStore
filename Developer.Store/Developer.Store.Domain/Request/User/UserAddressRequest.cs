﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer.Store.Domain.Request.User
{
    public class UserAddressRequest
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Zipcode { get; set; }
        public AddressGeolocationRequest Geolocatio { get; set; }
    }
}
