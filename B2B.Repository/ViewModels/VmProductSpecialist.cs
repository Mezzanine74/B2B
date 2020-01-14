using B2B.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Repository.ViewModels
{
    public class VmProductSpecialist : IProductSpecialist
    {
        public int Id {get; set;}
        public string Description {get; set;}
    }
}
