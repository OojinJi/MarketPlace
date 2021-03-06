//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketPlace.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProduct
    {
        public int Product_ID { get; set; }
        public int Manufacturer_ID { get; set; }
        public int SubCategory_ID { get; set; }
        public string Product_Name { get; set; }
        public byte[] Product_Image { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public Nullable<int> Model_Year { get; set; }
        public string Series_Info { get; set; }
        public Nullable<bool> Featured { get; set; }
    
        public virtual tblManufacturer tblManufacturer { get; set; }
        public virtual tblSubCategory tblSubCategory { get; set; }
    }
}
