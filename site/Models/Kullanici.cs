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
    
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            this.Carilers = new HashSet<Cariler>();
            this.Faturas = new HashSet<Fatura>();
            this.FaturaSatirlaris = new HashSet<FaturaSatirlari>();
        }
    
        public int U_ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Isim { get; set; }
        public string Sifre { get; set; }
        public string SoyIsim { get; set; }
        public Nullable<int> YetkiID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cariler> Carilers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Faturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaSatirlari> FaturaSatirlaris { get; set; }
        public virtual Yetkilendirme Yetkilendirme { get; set; }
    }
}
