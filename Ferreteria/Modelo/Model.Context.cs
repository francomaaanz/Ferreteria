﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ferreteria.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FERRETERIAEntities : DbContext
    {
        public FERRETERIAEntities()
            : base("name=FERRETERIAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Estado_Pedido> Estado_Pedido { get; set; }
        public DbSet<PEDIDO_PROVEEDOR> PEDIDO_PROVEEDOR { get; set; }
        public DbSet<PRODUCTO_FALTANTE_ROTO> PRODUCTO_FALTANTE_ROTO { get; set; }
        public DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public DbSet<CLIENTE> CLIENTE { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
    }
}
