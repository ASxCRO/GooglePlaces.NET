//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supan_RegionPoints
    {
        public short ID { get; set; }
        public short ID_REGIJE { get; set; }
        public decimal LAT { get; set; }
        public decimal LNG { get; set; }
    
        public virtual Supan_Regions Supan_Regions { get; set; }
    }
}
