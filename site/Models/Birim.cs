//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace site.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Birim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Birim()
        {
            this.Malzemelers = new HashSet<Malzemeler>();
        }
    
        public int B_ID { get; set; }
        public string BirimKodu { get; set; }
        public string BirimAdi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Malzemeler> Malzemelers { get; set; }
    }
}