﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneEnvanterYonetimSistemi.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbHEYSEntities : DbContext
    {
        public DbHEYSEntities()
            : base("name=DbHEYSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBLBilgiIslem> TBLBilgiIslem { get; set; }
        public virtual DbSet<TBLEnvanter> TBLEnvanter { get; set; }
        public virtual DbSet<TBLHastaneBolum> TBLHastaneBolum { get; set; }
        public virtual DbSet<TBLKullanıcı> TBLKullanıcı { get; set; }
        public virtual DbSet<TBLPersonel> TBLPersonel { get; set; }
        public virtual DbSet<TBLTeknikServis> TBLTeknikServis { get; set; }
        public virtual DbSet<TBLYetki> TBLYetki { get; set; }
    
        public virtual ObjectResult<EnvanterListesi_Result> EnvanterListesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnvanterListesi_Result>("EnvanterListesi");
        }
    
        public virtual ObjectResult<EnvanterListele_Result> EnvanterListele()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnvanterListele_Result>("EnvanterListele");
        }
    }
}
