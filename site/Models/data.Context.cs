﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace site.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class data : DbContext
    {
        public data()
            : base("name=data")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Birim> Birims { get; set; }
        public virtual DbSet<Cariler> Carilers { get; set; }
        public virtual DbSet<Fatura> Faturas { get; set; }
        public virtual DbSet<FaturaSatirlari> FaturaSatirlaris { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<Malzemeler> Malzemelers { get; set; }
        public virtual DbSet<Yetkilendirme> Yetkilendirmes { get; set; }
    }
}
