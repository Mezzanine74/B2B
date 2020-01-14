using B2B.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace B2B.WebMVC.Helpers
{
    public class FKandNavigationProperty
    {
        public FKandNavigationProperty()
        {
        }

        public string FK { get; set; }
        public PropertyInfo Navigation { get; set; }
        public IEnumerable<IEntity> Repo { get; set; }
        public string TextField { get; set; }
        public string ValueField { get; set; }
    }
}