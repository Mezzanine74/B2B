using B2B.Data.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B2B.WebMVC.Controllers
{
    public class TestBrandController : CRUDController<Brand> { }
    public class TestPaymentMethodController : CRUDController<PaymentMethod> { }
    public class TestPeriodOfMaxSellAmountController : CRUDController<PeriodOfMaxSellAmount> { }
    public class TestProductInformationController : CRUDController<ProductInformation> { }
    public class TestProductSpecialistController : CRUDController<ProductSpecialist> { }
    public class TestStockTypeController : CRUDController<StockType> { }
    public class TestSupplierController : CRUDController<Supplier> { }
    public class TestVATController : CRUDController<VAT> { }

}