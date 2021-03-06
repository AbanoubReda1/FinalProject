//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Roles = new HashSet<Role>();
        }
    
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Level { get; set; }
        public int Mobile { get; set; }
        public string StudentEmail { get; set; }
        public string Password { get; set; }
        public bool Verification { get; set; }
        public Nullable<System.Guid> ActivationCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Roles { get; set; }
    }
}
