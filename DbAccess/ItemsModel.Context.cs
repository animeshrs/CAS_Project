﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ItemEntities : DbContext
    {
        public ItemEntities()
            : base("name=ItemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AldiStore> AldiStores { get; set; }
        public virtual DbSet<CostCutterStore> CostCutterStores { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<LidlStore> LidlStores { get; set; }
        public virtual DbSet<TescoStore> TescoStores { get; set; }
    
        public virtual ObjectResult<getComparison_Result> getComparison()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getComparison_Result>("getComparison");
        }
    }
}
