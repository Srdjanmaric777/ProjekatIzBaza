//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatBaze
{
    using System;
    using System.Collections.Generic;
    
    public partial class ObicanVezbac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObicanVezbac()
        {
            this.ProbniTrenings = new HashSet<ProbniTrening>();
        }
    
        public int IdObicanVezbac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int OpremaZaVezbanje { get; set; }
        public Nullable<int> OpremaUteretaniIdOprema { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProbniTrening> ProbniTrenings { get; set; }
        public virtual OpremaUteretani OpremaUteretani { get; set; }
    }
}
