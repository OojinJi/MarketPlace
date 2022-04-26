using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.ServiceLayer
{
    public class ProductDTO
    {
        public int Product_ID { get; set; }
        public string Manufacturer_Name{ get; set; }        
        public string SubCategory_Name { get; set; }    
        public string Product_Name { get; set; }
        public byte[] Product_Image { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }   
        public int Model_Year { get; set; }   
        public string Series_Info { get; set; } 
       
    }
}
