﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class B2BEntities : DbContext
    {
        public B2BEntities()
            : base("name=B2BEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<PeriodOfMaxSellAmount> PeriodOfMaxSellAmounts { get; set; }
        public virtual DbSet<ProductInformation> ProductInformations { get; set; }
        public virtual DbSet<ProductSpecialist> ProductSpecialists { get; set; }
        public virtual DbSet<StockType> StockTypes { get; set; }
        public virtual DbSet<VAT> VATs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TestSex> TestSexes { get; set; }
        public virtual DbSet<SubTestPersonDescription> SubTestPersonDescriptions { get; set; }
        public virtual DbSet<SubTestPersonSurname> SubTestPersonSurnames { get; set; }
        public virtual DbSet<TestPerson> TestPersons { get; set; }
    
        public virtual ObjectResult<SpTestPersonList_Result> SpTestPersonList(string lang)
        {
            var langParameter = lang != null ?
                new ObjectParameter("Lang", lang) :
                new ObjectParameter("Lang", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpTestPersonList_Result>("SpTestPersonList", langParameter);
        }
    }
}