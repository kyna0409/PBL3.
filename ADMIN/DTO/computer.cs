//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADMIN.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class computer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public computer()
        {
            this.records = new HashSet<record>();
        }
    
        public int id { get; set; }
        public Nullable<bool> active_status { get; set; }
        public string ip { get; set; }
        public string location { get; set; }
        public string manufacturer { get; set; }
        public string warranty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<record> records { get; set; }
    }
}