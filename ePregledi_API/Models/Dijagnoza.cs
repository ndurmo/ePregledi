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
    
    public partial class Dijagnoza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dijagnoza()
        {
            this.DijagnozaPregleds = new HashSet<DijagnozaPregled>();
        }
    
        public int DijagnozaId { get; set; }
        public string Naziv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DijagnozaPregled> DijagnozaPregleds { get; set; }
    }
}