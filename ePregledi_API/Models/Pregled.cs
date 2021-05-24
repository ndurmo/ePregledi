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
    
    public partial class Pregled
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pregled()
        {
            this.DijagnozaPregleds = new HashSet<DijagnozaPregled>();
            this.LijekPregleds = new HashSet<LijekPregled>();
        }
    
        public int PregledId { get; set; }
        public System.DateTime DatumRezervisanja { get; set; }
        public System.DateTime DatumPregleda { get; set; }
        public int PacijentId { get; set; }
        public int DoktorId { get; set; }
        public string Napomena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DijagnozaPregled> DijagnozaPregleds { get; set; }
        public virtual Doktor Doktor { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LijekPregled> LijekPregleds { get; set; }
    }
}