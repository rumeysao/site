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
    
    public partial class Fatura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fatura()
        {
            this.Carilers = new HashSet<Cariler>();
            this.FaturaSatirlaris = new HashSet<FaturaSatirlari>();
        }
    
        public int F_ID { get; set; }
        public Nullable<int> TRCode { get; set; }
        public string FisNo { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<System.TimeSpan> Saat { get; set; }
        public Nullable<bool> İptal { get; set; }
        public Nullable<double> ToplamKDV { get; set; }
        public Nullable<int> U_ID { get; set; }
        public Nullable<double> Toplam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cariler> Carilers { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaSatirlari> FaturaSatirlaris { get; set; }
    }
}
