﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FiliFilmEntities : DbContext
    {
        public FiliFilmEntities()
            : base("name=FiliFilmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cast> Cast { get; set; }
        public virtual DbSet<Cinsiyet> Cinsiyet { get; set; }
        public virtual DbSet<Dil> Dil { get; set; }
        public virtual DbSet<Filmler> Filmler { get; set; }
        public virtual DbSet<Giris> Giris { get; set; }
        public virtual DbSet<Oyuncular> Oyuncular { get; set; }
        public virtual DbSet<Tur> Tur { get; set; }
        public virtual DbSet<Ulke> Ulke { get; set; }
        public virtual DbSet<Yonetmen> Yonetmen { get; set; }
    }
}
