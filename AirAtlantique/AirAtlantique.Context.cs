﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirAtlantique
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirAtlantiqueDBContext : DbContext
    {
        public AirAtlantiqueDBContext()
            : base("name=AirAtlantiqueDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Employes_Sessions> Employes_Sessions { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}
