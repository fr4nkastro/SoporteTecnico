//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLE_ORDEN_TRABAJO
    {
        public decimal id { get; set; }
        public Nullable<decimal> ordenTrabajoID { get; set; }
        public Nullable<decimal> tecnicoId { get; set; }
        public Nullable<decimal> servicioID { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> contratoID { get; set; }
    
        public virtual CONTRATOS CONTRATOS { get; set; }
        public virtual ORDEN_TRABAJO ORDEN_TRABAJO { get; set; }
        public virtual SERVICIOS SERVICIOS { get; set; }
        public virtual TECNICOS TECNICOS { get; set; }
    }
}
