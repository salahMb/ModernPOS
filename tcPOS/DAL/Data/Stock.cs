//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public long ID { get; set; }
        public Nullable<long> Product_ID { get; set; }
        public Nullable<System.DateTime> Last_Time_Updated { get; set; }
        public Nullable<int> In_Stock { get; set; }
        public string Updated_By { get; set; }
    }
}
