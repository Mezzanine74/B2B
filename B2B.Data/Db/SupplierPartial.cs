using B2B.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Data.Db
{
    [MetadataType(typeof(SupplierMetadata))]
    public partial class Supplier : ISupplier
    {
        // Note this class has nothing in it.  It's just here to add the class-level attribute.
    }

    public class SupplierMetadata : ISupplier
    {
        public int Id { get; set; }

        [Display(Name = "Description", ResourceType = typeof(Resources.DbFields))]
        public string Description { get; set; }
    }

}
