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
    
    public partial class Order_Details
    {
        public long ID { get; set; }
        public Nullable<long> Order_ID { get; set; }
        public Nullable<long> Product_ID { get; set; }
        public Nullable<double> Unit_Price { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> Discount { get; set; }
    }
}
