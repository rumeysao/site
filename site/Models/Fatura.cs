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
    using System.ComponentModel.DataAnnotations;

    
    public partial class Fatura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fatura()
        {
            this.FaturaSatirlaris = new HashSet<FaturaSatirlari>();
        }
        [Display(Name = "Fatura �D")]
        public int Fatura_ID { get; set; }
        [Display(Name = "Fatura Seri No")]
        public string FaturaSeriNo { get; set; }
        [Display(Name = "Fatura S�ra NO")]
        public string FaturaSiraNo { get; set; }
       
        public string Saat { get; set; }

        public Nullable<System.DateTime> Tarih { get; set; } = DateTime.Now;
       
        public Nullable<decimal> Toplam { get; set; }
        [Display(Name = "Cari �D")]
        public Nullable<int> Cari_ID { get; set; }
        [Display(Name = "Kullan�c� �D")]
        public Nullable<int> Kullanici_ID { get; set; }
        [Display(Name = "Birim �D")]
        public Nullable<int> Birim_ID { get; set; }
    
        public virtual Birim Birim { get; set; }
        public virtual Cari Cari { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaSatirlari> FaturaSatirlaris { get; set; }
    }
}
