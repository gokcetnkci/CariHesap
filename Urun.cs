//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CariHesap
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            this.Satis = new HashSet<Satis>();
        }
    
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public Nullable<int> KategoriId { get; set; }
        public int AlisFiyati { get; set; }
        public int SatisFiyati { get; set; }
        public Nullable<int> UrunStok { get; set; }
        public string Aciklama { get; set; }
    
        public virtual Kategori Kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
