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
    
    public partial class Malzemeler
    {
        public int Malzeme_ID { get; set; }
        public string MalzemeKodu { get; set; }
        public string MalzemeAdi { get; set; }
        public string OzelKod { get; set; }
        public Nullable<double> KDV { get; set; }
        public Nullable<System.DateTime> OlusturmaTarihi { get; set; }
        public Nullable<System.DateTime> DuzenlemeTarihi { get; set; }
        public Nullable<int> Birim_ID { get; set; }
    
        public virtual Birim Birim { get; set; }
        public virtual FaturaSatirlari FaturaSatirlari { get; set; }
    }
}
