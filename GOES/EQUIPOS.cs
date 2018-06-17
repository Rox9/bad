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
    
    public partial class EQUIPOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EQUIPOS()
        {
            this.ALERTAS = new HashSet<ALERTAS>();
            this.DETALLE_INSTALACION = new HashSet<DETALLE_INSTALACION>();
            this.DETALLE_MANTENIMIENTO = new HashSet<DETALLE_MANTENIMIENTO>();
            this.DOCUMENTOS = new HashSet<DOCUMENTOS>();
        }
    
        public int EQUIPO_ID { get; set; }
        public int COMPRA_ID { get; set; }
        public string EQUIPO_NOMBRE { get; set; }
        public string EQUIPO_MARCA { get; set; }
        public string EQUIPO_MODELO { get; set; }
        public System.DateTime EQUIPO_FECHA_COMPRA { get; set; }
        public Nullable<int> EQUIPO_ANIO_FABRICACION { get; set; }
        public Nullable<float> EQUIPO_BTU { get; set; }
        public Nullable<float> EQUIPO_POTENCIA { get; set; }
        public Nullable<System.DateTime> EQUIPO_MANTENIMIENTO { get; set; }
        public bool EQUIPO_ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALERTAS> ALERTAS { get; set; }
        public virtual COMPRAS COMPRAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_INSTALACION> DETALLE_INSTALACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_MANTENIMIENTO> DETALLE_MANTENIMIENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTOS> DOCUMENTOS { get; set; }
    }
}
