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
    
    public partial class DETALLE_COMPRAS
    {
        public int DET_COMPRA_ID { get; set; }
        public int COMPRA_ID { get; set; }
        public int DET_COMPRA_CANTIDAD { get; set; }
        public string DET_COMPRA_DESCRIPCION { get; set; }
        public float DET_COMPRA_PRECIO { get; set; }
    
        public virtual COMPRAS COMPRAS { get; set; }
    }
}
