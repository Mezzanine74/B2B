using B2B.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Data.Interfaces
{
    public interface IProductInformation : IEntity
    {
        Nullable<int> BrandId { get; set; }
        Nullable<bool> Status { get; set; }
        Nullable<int> StockCode { get; set; }
        Nullable<int> StockTypeId { get; set; }
        Nullable<int> PaymentMethodId { get; set; }
        Nullable<int> VATId { get; set; }
        Nullable<bool> SellIfNotInStock { get; set; }
        Nullable<bool> ShowInMainPage { get; set; }
        Nullable<bool> UserComment { get; set; }
        Nullable<int> ShowOrder { get; set; }
        Nullable<int> SupplierId { get; set; }
        string ManufacturerCode { get; set; }
        Nullable<int> ProductSpecialistId { get; set; }
        Nullable<int> MaxSellCount { get; set; }
        Nullable<int> PeriodOfMaxSellAmountId { get; set; }
        string ShortDescription { get; set; }
        string KeyWords { get; set; }
    }
}
