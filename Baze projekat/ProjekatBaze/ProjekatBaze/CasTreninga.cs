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
    
    public partial class CasTreninga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CasTreninga()
        {
            this.Uzimas = new HashSet<Uzima>();
            this.Drzis = new HashSet<Drzi>();
        }
    
        public int IdCasTreninga { get; set; }
        public System.DateTime DatumIVreme { get; set; }
        public int BrojClanova { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uzima> Uzimas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Drzi> Drzis { get; set; }
    }
}