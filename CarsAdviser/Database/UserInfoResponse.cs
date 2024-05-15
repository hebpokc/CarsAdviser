using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CarsAdviser.Database
{
    public class UserInfoResponse
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Default_Email { get; set; }
        public DefaultPhone Default_phone { get; set; } 
    }

    public class DefaultPhone
    {
        public int Id { get; set; }
        public string Number { get; set; }
    }
}
