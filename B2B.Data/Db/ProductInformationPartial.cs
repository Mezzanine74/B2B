using B2B.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Data.Db
{
    [MetadataType(typeof(ProductInformationMetadata))]
    public partial class ProductInformation : IProductInformation
    {
        // Note this class has nothing in it.  It's just here to add the class-level attribute.
    }

    public class ProductInformationMetadata : IProductInformation
    {
        public int Id { get; set; }

        [Display(Name = "Description", ResourceType = typeof(Resources.DbFields))]
        public string Description { get; set; }

        [Display(Name = "Brand", ResourceType = typeof(Resources.DbFields))]
        public int? BrandId {get; set;}
        [Display(Name = "Status", ResourceType = typeof(Resources.DbFields))]
        public bool? Status {get; set;}
        [Display(Name = "StockCode", ResourceType = typeof(Resources.DbFields))]
        public int? StockCode {get; set;}

        [Display(Name = "StockType", ResourceType = typeof(Resources.DbFields))]
        public int? StockTypeId {get; set;}

        [Display(Name = "PaymentMethod", ResourceType = typeof(Resources.DbFields))]
        public int? PaymentMethodId {get; set;}

        [Display(Name = "VAT", ResourceType = typeof(Resources.DbFields))]
        public int? VATId {get; set;}

        [Display(Name = "SellIfNotInStock", ResourceType = typeof(Resources.DbFields))]
        public bool? SellIfNotInStock {get; set;}
        [Display(Name = "ShowInMainPage", ResourceType = typeof(Resources.DbFields))]
        public bool? ShowInMainPage {get; set;}
        [Display(Name = "UserComment", ResourceType = typeof(Resources.DbFields))]
        public bool? UserComment {get; set;}
        [Display(Name = "ShowOrder", ResourceType = typeof(Resources.DbFields))]
        public int? ShowOrder {get; set;}

        [Display(Name = "Supplier", ResourceType = typeof(Resources.DbFields))]
        public int? SupplierId {get; set;}
        [Display(Name = "ManufacturerCode", ResourceType = typeof(Resources.DbFields))]
        public string ManufacturerCode {get; set;}

        [Display(Name = "ProductSpecialist", ResourceType = typeof(Resources.DbFields))]
        public int? ProductSpecialistId {get; set;}

        [Display(Name = "MaxSellCount", ResourceType = typeof(Resources.DbFields))]
        public int? MaxSellCount {get; set;}

        [Display(Name = "PeriodOfMaxSellAmount", ResourceType = typeof(Resources.DbFields))]
        public int? PeriodOfMaxSellAmountId {get; set;}
        [Display(Name = "ShortDescription", ResourceType = typeof(Resources.DbFields))]
        public string ShortDescription {get; set;}

        [Display(Name = "KeyWords", ResourceType = typeof(Resources.DbFields))]
        public string KeyWords {get; set;}
    }

}
