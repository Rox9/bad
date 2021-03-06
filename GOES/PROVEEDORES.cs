//------------------------------------------------------------------------------
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
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;
    
    public partial class PROVEEDORES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVEEDORES()
        {
            this.COMPRAS = new HashSet<COMPRAS>();
            this.INSTALACIONES = new HashSet<INSTALACIONES>();
            this.MANTENIMIENTOS = new HashSet<MANTENIMIENTOS>();
            this.OFERTAS = new HashSet<OFERTAS>();
            this.PRODUCTOS_PROVEEDOR = new HashSet<PRODUCTOS_PROVEEDOR>();
            this.USUARIOS = new HashSet<USUARIOS>();
            this.INSTITUCIONES = new HashSet<INSTITUCIONES>();
        }

        [Display(Name = "ID PROVEEDOR")]
        public int PROVEEDOR_ID { get; set; }
        [Display(Name = "MUNICIPIO")]
        public int MUNICIPIO_ID { get; set; }
        [Display(Name = "NOMBRE DE EMPRESA")]
        public string PROVEEDOR_EMPRESA { get; set; }
        [Display(Name = "CONTACTO")]
        public string PROVEEDOR_CONTACTO { get; set; }
        [Display(Name = "TELEFONO 1")]
        public string PROVEEDOR_TELEFONO1 { get; set; }
        [Display(Name = "TELEFONO 2")]
        public string PROVEEDOR_TELEFONO2 { get; set; }
        [Display(Name = "CORREO")]
        public string PROVEEDOR_CORREO { get; set; }
        [Display(Name = "NIT")]
        public string PROVEEDOR_NIT { get; set; }
        [Display(Name = "DESCRIPCION")]
        public string PROVEEDOR_DESCRIPCION { get; set; }
        [Display(Name = "DIRECCION")]
        public string PROVEEDOR_DIRECCION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAS> COMPRAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSTALACIONES> INSTALACIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MANTENIMIENTOS> MANTENIMIENTOS { get; set; }
        public virtual MUNICIPIOS MUNICIPIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OFERTAS> OFERTAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTOS_PROVEEDOR> PRODUCTOS_PROVEEDOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOS> USUARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSTITUCIONES> INSTITUCIONES { get; set; }
    }
}
