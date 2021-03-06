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
    
    public partial class PRODUCTOS_PROVEEDOR
    {
        [Display(Name = "ID PRODUCTO")]
        public int PROD_PROVEEDOR_ID { get; set; }
        [Display(Name = "ID PROVEEDOR")]
        public int PROVEEDOR_ID { get; set; }
        [Display(Name = "NOMBRE DE PRODUCTO")]
        public string PROD_PROVEEDOR_NOMBRE { get; set; }
        [Display(Name = "MARCA")]
        public string PROD_PROVEEDOR_MARCA { get; set; }
        [Display(Name = "MODELO")]
        public string PROD_PROVEEDOR_MODELO { get; set; }
        [Display(Name = "AÑO")]
        public Nullable<int> PROD_PROVEEDOR_ANIO { get; set; }
        [Display(Name = "BTU")]
        public Nullable<float> PROD_PROVEEDOR_BTU { get; set; }
        [Display(Name = "POTENCIA")]
        public Nullable<float> PROD_PROVEEDOR_POTENCIA { get; set; }
        [Display(Name = "COLOR")]
        public string PROD_PROVEEDOR_COLOR { get; set; }
        [Display(Name = "EXISTENCIAS")]
        public Nullable<int> PROD_PROVEEDOR_EXISTENCIAS { get; set; }
        [Display(Name = "DESCRIPCION")]
        public string PROD_PROVEEDOR_DESCRIPCION { get; set; }
        [Display(Name = "VOLTAJE")]
        public Nullable<float> PROD_PROVEEDOR_VOLTAJE { get; set; }
        [Display(Name = "AREA")]
        public Nullable<float> PROD_PROVEEDOR_AREA { get; set; }

        [Display(Name = "PROVEEDORES")]
        public virtual PROVEEDORES PROVEEDORES { get; set; }
    }
}
