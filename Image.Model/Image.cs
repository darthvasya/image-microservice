//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Image.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string name_starter { get; set; }
        public string size { get; set; }
        public System.DateTime date_download { get; set; }
        public bool deleted { get; set; }
        public Nullable<System.DateTime> date_delete { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public Nullable<int> id_owner { get; set; }
    }
}
