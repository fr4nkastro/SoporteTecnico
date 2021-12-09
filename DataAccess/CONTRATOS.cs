//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTRATOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTRATOS()
        {
            this.DETALLE_CONTRATO = new HashSet<DETALLE_CONTRATO>();
            this.DETALLE_ORDEN_TRABAJO = new HashSet<DETALLE_ORDEN_TRABAJO>();
        }
    
        public decimal id { get; set; }
        public Nullable<decimal> clienteID { get; set; }
        public Nullable<System.DateTime> fechaContrato { get; set; }
        public Nullable<System.DateTime> fechaFinalizacion { get; set; }
        public Nullable<decimal> tecnicoID { get; set; }
        public Nullable<decimal> retrasos { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_CONTRATO> DETALLE_CONTRATO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_ORDEN_TRABAJO> DETALLE_ORDEN_TRABAJO { get; set; }
        public virtual TECNICOS TECNICOS { get; set; }
    }
}
