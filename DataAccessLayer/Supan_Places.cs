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
    
    public partial class Supan_Places
    {
        public int PLACE_ID { get; set; }
        public string PLACE_NAME { get; set; }
        public decimal PLACE_LAT { get; set; }
        public decimal PLACE_LNG { get; set; }
        public Nullable<int> PLACE_TYPE { get; set; }
        public string PLACE_ADDRESS { get; set; }
    
        public virtual Supan_PlaceTypes Supan_PlaceTypes { get; set; }
    }
}
