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
    
    public partial class Cari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cari()
        {
            this.Faturas = new HashSet<Fatura>();
        }
    
        public int Cari_ID { get; set; }
        public string CariKodu { get; set; }
        public string Tanim { get; set; }
        public string Adres { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        [DataType(DataType.PhoneNumber)]
        public Nullable<int> Tel { get; set; }

        public Nullable<int> Fax { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Web { get; set; }
        [DataType(DataType.PostalCode)]
        
        public Nullable<int> PostaKodu { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<int> FaturaSatirlari_ID { get; set; }
        public Nullable<int> Kullanici_ID { get; set; }
    
        public virtual FaturaSatirlari FaturaSatirlari { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Faturas { get; set; }
    }
}
