//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team5BLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Loandetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loandetail()
        {
            this.Returndetails = new HashSet<Returndetail>();
        }
    
        public int loandetailsid { get; set; }
        public int memberid { get; set; }
        public int bookid { get; set; }
        public System.DateTime startdate { get; set; }
        public System.DateTime enddate { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Returndetail> Returndetails { get; set; }
    }
}