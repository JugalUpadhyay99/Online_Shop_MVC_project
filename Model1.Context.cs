﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practisequestion16
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EcommercedataEntities : DbContext
    {
        public EcommercedataEntities()
            : base("name=EcommercedataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brandtable> Brandtables { get; set; }
        public virtual DbSet<Categorytable> Categorytables { get; set; }
        public virtual DbSet<Producttable> Producttables { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
    }
}
