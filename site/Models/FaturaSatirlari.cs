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
    
    public partial class FaturaSatirlari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FaturaSatirlari()
        {
            this.Caris = new HashSet<Cari>();
            this.Faturas = new HashSet<Fatura>();
        }
        [Display(Name = "Fatura Satirlari �d")]

        public int Faturasatirlari_ID { get; set; }
        public Nullable<double> Tutar { get; set; }
        public Nullable<double> Fiyat { get; set; }
        public Nullable<double> KDV { get; set; }
        public Nullable<int> Miktar { get; set; }
        [Display(Name = "Birim �d")]

        public Nullable<int> Birim_ID { get; set; }
        [Display(Name = "Malzeme �d")]

        public Nullable<int> Malzeme_ID { get; set; }
        [Display(Name = "Kullan�c� �d")]

        public Nullable<int> Kullanici_ID { get; set; }
        [Display(Name = "A��klama")]

        public string Aciklama { get; set; }
    
        public virtual Birim Birim { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cari> Caris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Faturas { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Malzemeler Malzemeler { get; set; }
        
    }
}
