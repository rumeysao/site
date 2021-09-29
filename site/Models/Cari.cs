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
        [Display(Name ="Cari �d")]
        public int Cari_ID { get; set; }
        [Display(Name = "Cari Kodu")]

        public string CariKodu { get; set; }
        [Display(Name = "Tan�m")]

        public string Tanim { get; set; }
       

        public string Adres { get; set; }
        [Display(Name = "�lke")]


        public string Ulke { get; set; }
        [Display(Name = "�ehir")]

        public string Sehir { get; set; }
        [Display(Name = "�l�e")]

        public string Ilce { get; set; }
        [Display(Name = "Telefon Numaras�")]

        [Required(ErrorMessage ="L�tfen bu alan� bo� ge�meyiniz.")]
       [DataType(DataType.PhoneNumber,ErrorMessage ="L�tfen ge�erli formatta bilgi giriniz.")]
        public Nullable<int> Tel { get; set; }
        [Display(Name = "Fax numaras�")]

        public Nullable<int> Fax { get; set; }
        [Display(Name = "E-mail")]

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Web Adresi")]

        public string Web { get; set; }
        [Display(Name = "Posta Kodu")]

        [DataType(DataType.PostalCode)]
        public Nullable<int> PostaKodu { get; set; }
        

        public Nullable<bool> Aktif { get; set; }
        [Display(Name = "Datura Sat�rlar� �d")]

        public Nullable<int> FaturaSatirlari_ID { get; set; }
        [Display(Name = "Kullan�c� �d")]

        public Nullable<int> Kullanici_ID { get; set; }
    
        public virtual FaturaSatirlari FaturaSatirlari { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fatura> Faturas { get; set; }
        public List<Cari> ListOfCari { get; set; }
    }
}
