//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Source.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class topic_blocks
    {
        public int id { get; set; }
        public int topic_id { get; set; }
        public string title { get; set; }
        public string responsive_class { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public string updated_by { get; set; }
    
        public virtual Topic Topic { get; set; }
    }
}