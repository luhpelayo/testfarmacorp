//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capaDALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class CodigosBarras
    {
        public int IdCodigoBarra { get; set; }
        public Nullable<System.Guid> UniqueCodigo { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<int> IdProducto { get; set; }
    
        public virtual ExpProductos ExpProductos { get; set; }
    }
}
