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
    
    public partial class table_practice
    {
        public int idTable { get; set; }
        public short numberPractice { get; set; }
        public short partPractice { get; set; }
        public string linkPractice { get; set; }
        public string idUploader { get; set; }
        public short groupeNumberPracticeClass { get; set; }
        public bool termPracticeClass { get; set; }
        public short numberYearFromStart { get; set; }
        public bool deleted { get; set; }
    
        public virtual table_user table_user { get; set; }
    }
}