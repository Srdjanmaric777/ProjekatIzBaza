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
    
    public partial class Radi
    {
        public int TeratanaLokacija { get; set; }
        public int ZaposleniIdBedz { get; set; }
    
        public virtual Teratana Teratana { get; set; }
        public virtual Zaposleni Zaposleni { get; set; }
    }
}
