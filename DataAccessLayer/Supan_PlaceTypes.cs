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
    
    public partial class Supan_PlaceTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supan_PlaceTypes()
        {
            this.Supan_Places = new HashSet<Supan_Places>();
        }
    
        public int TYPE_ID { get; set; }
        public string TYPE_NAME { get; set; }
        public string TYPE_VALUE { get; set; }
        public Nullable<bool> TYPE_ALLOWED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supan_Places> Supan_Places { get; set; }
    }
}
