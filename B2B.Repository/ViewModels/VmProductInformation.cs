using B2B.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Repository.ViewModels
{
    public class VmProductInformation : IProductInformation
    {
        public int? BrandId {get; set;}
        public bool? Status {get; set;}
        public int? StockCode {get; set;}
        public int? StockTypeId {get; set;}
        public int? PaymentMethodId {get; set;}
        public int? VATId {get; set;}
        public bool? SellIfNotInStock {get; set;}
        public bool? ShowInMainPage {get; set;}
        public bool? UserComment {get; set;}
        public int? ShowOrder {get; set;}
        public int? SupplierId {get; set;}
        public string ManufacturerCode {get; set;}
        public int? ProductSpecialistId {get; set;}
        public int? MaxSellCount {get; set;}
        public int? PeriodOfMaxSellAmountId {get; set;}
        public string ShortDescription {get; set;}
        public string KeyWords {get; set;}
        public int Id {get; set;}
        public string Description {get; set;}
    }
}
