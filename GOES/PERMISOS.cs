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
    
    public partial class PERMISOS
    {
        public int PERMISO_ID { get; set; }
        public int PANTALLA_ID { get; set; }
        public int ROL_ID { get; set; }
    
        public virtual PANTALLAS PANTALLAS { get; set; }
        public virtual ROLES ROLES { get; set; }
    }
}
