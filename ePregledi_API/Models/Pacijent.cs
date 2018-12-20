//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ePregledi_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pacijent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacijent()
        {
            this.Pregleds = new HashSet<Pregled>();
            this.Alergijas = new HashSet<Alergija>();
        }
    
        public int PacijentId { get; set; }
        public Nullable<int> KrvnaGrupaID { get; set; }
        public string BrojKnjizice { get; set; }
        public string BrojKartona { get; set; }
        public string Visina { get; set; }
        public string Tezina { get; set; }
        public string SpecijalniZahtjevi { get; set; }
    
        public virtual KrvnaGrupa KrvnaGrupa { get; set; }
        public virtual Osoba Osoba { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pregled> Pregleds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alergija> Alergijas { get; set; }
    }
}
