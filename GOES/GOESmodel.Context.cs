﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GOES
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDLUPITAEntities : DbContext
    {
        public BDLUPITAEntities()
            : base("name=BDLUPITAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ALERTAS> ALERTAS { get; set; }
        public virtual DbSet<APROBADOS> APROBADOS { get; set; }
        public virtual DbSet<BITACORA> BITACORA { get; set; }
        public virtual DbSet<COMPRAS> COMPRAS { get; set; }
        public virtual DbSet<CONTRATOS> CONTRATOS { get; set; }
        public virtual DbSet<DEPARTAMENTOS> DEPARTAMENTOS { get; set; }
        public virtual DbSet<DEPARTAMENTOS_INSTITUCION> DEPARTAMENTOS_INSTITUCION { get; set; }
        public virtual DbSet<DETALLE_COMPRAS> DETALLE_COMPRAS { get; set; }
        public virtual DbSet<DETALLE_INSTALACION> DETALLE_INSTALACION { get; set; }
        public virtual DbSet<DETALLE_MANTENIMIENTO> DETALLE_MANTENIMIENTO { get; set; }
        public virtual DbSet<DETALLE_SOLICITUD> DETALLE_SOLICITUD { get; set; }
        public virtual DbSet<DOCUMENTOS> DOCUMENTOS { get; set; }
        public virtual DbSet<EQUIPOS> EQUIPOS { get; set; }
        public virtual DbSet<INSTALACIONES> INSTALACIONES { get; set; }
        public virtual DbSet<INSTITUCIONES> INSTITUCIONES { get; set; }
        public virtual DbSet<LICITACIONES> LICITACIONES { get; set; }
        public virtual DbSet<MANTENIMIENTOS> MANTENIMIENTOS { get; set; }
        public virtual DbSet<MUNICIPIOS> MUNICIPIOS { get; set; }
        public virtual DbSet<OFERTAS> OFERTAS { get; set; }
        public virtual DbSet<PANTALLAS> PANTALLAS { get; set; }
        public virtual DbSet<PERMISOS> PERMISOS { get; set; }
        public virtual DbSet<PRODUCTOS_INSTITUCION> PRODUCTOS_INSTITUCION { get; set; }
        public virtual DbSet<PRODUCTOS_PROVEEDOR> PRODUCTOS_PROVEEDOR { get; set; }
        public virtual DbSet<PROVEEDORES> PROVEEDORES { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<SOLICITUDES> SOLICITUDES { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TABLA_MENSAJE> TABLA_MENSAJE { get; set; }
        public virtual DbSet<TIPO_MANTENIMIENTOS> TIPO_MANTENIMIENTOS { get; set; }
        public virtual DbSet<TIPO_SOLICITUDES> TIPO_SOLICITUDES { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
    }
}
