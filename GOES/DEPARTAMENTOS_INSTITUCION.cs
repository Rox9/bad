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
    
    public partial class DEPARTAMENTOS_INSTITUCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPARTAMENTOS_INSTITUCION()
        {
            this.SOLICITUDES = new HashSet<SOLICITUDES>();
        }
    
        public int DEPTO_INSTITUCION_ID { get; set; }
        public int INSTITUCION_ID { get; set; }
        public string DEPTO_INSTITUCION_NOMBRE { get; set; }
        public string DEPTO_INSTITUCION_JEFE { get; set; }
        public string DEPTO_INSTITUCION_TELEFONO { get; set; }
        public string DEPTO_INSTITUCION_DESCRIPCION { get; set; }
    
        public virtual INSTITUCIONES INSTITUCIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUDES> SOLICITUDES { get; set; }
    }
}
