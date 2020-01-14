//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B2B.Data.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductInformation
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<int> BrandId { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> StockCode { get; set; }
        public Nullable<int> StockTypeId { get; set; }
        public Nullable<int> PaymentMethodId { get; set; }
        public Nullable<int> VATId { get; set; }
        public Nullable<bool> SellIfNotInStock { get; set; }
        public Nullable<bool> ShowInMainPage { get; set; }
        public Nullable<bool> UserComment { get; set; }
        public Nullable<int> ShowOrder { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public string ManufacturerCode { get; set; }
        public Nullable<int> ProductSpecialistId { get; set; }
        public Nullable<int> MaxSellCount { get; set; }
        public Nullable<int> PeriodOfMaxSellAmountId { get; set; }
        public string ShortDescription { get; set; }
        public string KeyWords { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PeriodOfMaxSellAmount PeriodOfMaxSellAmount { get; set; }
        public virtual ProductSpecialist ProductSpecialist { get; set; }
        public virtual StockType StockType { get; set; }
        public virtual VAT VAT { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
