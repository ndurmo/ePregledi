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
    
    public partial class DijagnozaPregled
    {
        public int PregledId { get; set; }
        public int DijagnozaId { get; set; }
        public string Opis { get; set; }
    
        public virtual Dijagnoza Dijagnoza { get; set; }
        public virtual Pregled Pregled { get; set; }
    }
}