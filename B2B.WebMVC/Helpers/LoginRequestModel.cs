using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B2B.WebMVC.Helpers
{
    public class LoginRequestModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string grant_type { get; set; }
    }
}