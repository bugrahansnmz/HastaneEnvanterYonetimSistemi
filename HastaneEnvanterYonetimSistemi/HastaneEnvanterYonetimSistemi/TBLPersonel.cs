//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HastaneEnvanterYonetimSistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLPersonel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLPersonel()
        {
            this.TBLHastaneBolum = new HashSet<TBLHastaneBolum>();
        }
    
        public int PersonelID { get; set; }
        public Nullable<int> BagliEnvanter { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public Nullable<int> Bolum { get; set; }
        public string Birim { get; set; }
        public string Mail { get; set; }
    
        public virtual TBLEnvanter TBLEnvanter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLHastaneBolum> TBLHastaneBolum { get; set; }
    }
}
