//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HalifaxScienceLibrary_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class author_articles
    {
        public int C_id { get; set; }
        public int article_id { get; set; }
        public System.DateTime time { get; set; }
    
        public virtual author author { get; set; }
        public virtual article article { get; set; }
    }
}
