using MarketPlace.DataLayer;
using MarketPlace.RepoLayer.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketPlace.ServiceLayer
{
    public class ProductService
    {
        public UnitOfWork uow { get; set; }
        public ProductService()
        {
            MarketPlaceEntities1 marketPlaceEntities = new MarketPlaceEntities1();
            uow = new UnitOfWork(marketPlaceEntities);
        }

        public IEnumerable<ProductDTO> ProductInfoByID(string ProductName)
        {
            var Manufacturers = uow.Manufacturers.GetAll();
            var Sub_Categories = uow.SubCategories.GetAll();
            var Products = uow.Products.GetAll();
            var result = (from p in Products
                          join m in Manufacturers on p.Manufacturer_ID equals m.Manufacturer_ID
                          join s in Sub_Categories on p.SubCategory_ID equals s.SubCategory_ID
                          where p.Product_Name == ProductName
                          select new ProductDTO
                          {
                              Product_ID = p.Product_ID,
                              Manufacturer_Name = m.Manufacturer_Name,
                              SubCategory_Name = s.SubCategory_Name,
                              ProductName = p.Product_Name,
                              Product_Image = p.Product_Image,
                              Series = p.Series,
                              Model_Year = (int)p.Model_Year,
                              Series_Info = p.Series_Info,
                              Featured = (bool)p.Featured
                          }).ToList();
            return result;



        }
    }
}
