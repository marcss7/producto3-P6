﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoDeTiempo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class btEntities : DbContext
    {
        public btEntities()
            : base("name=btEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> categorias { get; set; }
        public virtual DbSet<Factura> facturas { get; set; }
        public virtual DbSet<Movimiento> movimientos { get; set; }
        public virtual DbSet<Servicio> servicios { get; set; }
        public virtual DbSet<Solicitud> solicitudes { get; set; }
        public virtual DbSet<TipoServicio> tipo_servicio { get; set; }
        public virtual DbSet<Usuario> usuarios { get; set; }
    }
}
