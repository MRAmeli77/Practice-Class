//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticeClass
{
    using System;
    using System.Collections.Generic;
    
    public partial class table_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public table_user()
        {
            this.table_practice = new HashSet<table_practice>();
        }
    
        public string idUser { get; set; }
        public string firstNameUser { get; set; }
        public string lastNameUser { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_practice> table_practice { get; set; }
        public virtual table_professor table_professor { get; set; }
        public virtual table_student table_student { get; set; }
    }
}
