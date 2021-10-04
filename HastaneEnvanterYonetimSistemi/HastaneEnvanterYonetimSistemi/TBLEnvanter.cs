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
    
    public partial class TBLEnvanter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLEnvanter()
        {
            this.TBLBilgiIslem = new HashSet<TBLBilgiIslem>();
            this.TBLHastaneBolum = new HashSet<TBLHastaneBolum>();
            this.TBLPersonel = new HashSet<TBLPersonel>();
            this.TBLTeknikServis = new HashSet<TBLTeknikServis>();
        }
    
        public int EnvanterID { get; set; }
        public string UrunIsmi { get; set; }
        public Nullable<int> StokAdet { get; set; }
        public Nullable<System.DateTime> GirisTarihi { get; set; }
        public string BagliPersonel { get; set; }
        public string BagliBolum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBilgiIslem> TBLBilgiIslem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLHastaneBolum> TBLHastaneBolum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPersonel> TBLPersonel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLTeknikServis> TBLTeknikServis { get; set; }
    }
}