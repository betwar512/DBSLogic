//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogicAppDBS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract_task
    {
        public int Contract_id { get; set; }
        public string Task_name { get; set; }
        public string Task_description { get; set; }
    
        public virtual Contract Contract { get; set; }
    }
}