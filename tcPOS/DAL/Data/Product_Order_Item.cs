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
    
    public partial class Product_Order_Item
    {
        public long ID { get; set; }
        public Nullable<int> Quantity_Sold { get; set; }
        public Nullable<double> Price_Per_Unit { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<double> Tax_Amount { get; set; }
        public Nullable<long> Order_ID { get; set; }
        public Nullable<long> Product_ID { get; set; }
    }
}
