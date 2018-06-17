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
    
    public partial class COMPRAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRAS()
        {
            this.CONTRATOS = new HashSet<CONTRATOS>();
            this.DETALLE_COMPRAS = new HashSet<DETALLE_COMPRAS>();
            this.EQUIPOS = new HashSet<EQUIPOS>();
        }
    
        public int COMPRA_ID { get; set; }
        public int INSTITUCION_ID { get; set; }
        public Nullable<int> PROVEEDOR_ID { get; set; }
        public string COMPRA_FACTURA { get; set; }
        public System.DateTime COMPRA_FECHA { get; set; }
        public string COMPRA_VENDEDOR { get; set; }
        public Nullable<int> COMPRA_SOLICITUD_CODIGO { get; set; }
        public string COMPRA_RESPONSABLE { get; set; }
    
        public virtual PROVEEDORES PROVEEDORES { get; set; }
        public virtual INSTITUCIONES INSTITUCIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_COMPRAS> DETALLE_COMPRAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EQUIPOS> EQUIPOS { get; set; }
    }
}
