//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace caseABC.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parcel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parcel()
        {
            this.Tracking = new HashSet<Tracking>();
        }
    
        public int parcelId { get; set; }
        public int customerId { get; set; }
        public string pickupAddress { get; set; }
        public System.DateTime pickupDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracking> Tracking { get; set; }

        public object CustomerId { get; set; }
    }
}
