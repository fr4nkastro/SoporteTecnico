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
    
    public partial class TECNICOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TECNICOS()
        {
            this.CONTRATOS = new HashSet<CONTRATOS>();
            this.DETALLE_ORDEN_TRABAJO = new HashSet<DETALLE_ORDEN_TRABAJO>();
            this.DISPONIBILIDAD_TECNICOS = new HashSet<DISPONIBILIDAD_TECNICOS>();
        }
    
        public decimal id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string area { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_ORDEN_TRABAJO> DETALLE_ORDEN_TRABAJO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISPONIBILIDAD_TECNICOS> DISPONIBILIDAD_TECNICOS { get; set; }
    }
}
