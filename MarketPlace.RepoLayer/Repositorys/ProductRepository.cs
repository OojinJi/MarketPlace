using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace MarketPlace.RepoLayer.Repositorys
{
	public class ProductRepository : GenericRepository<tblProduct>, IProductRepository
	{
		//
		// TODO: Add constructor logic here
		//
		public ProductRepository(MarketPlaceEntities1 marketPlaceEntities): base(marketPlaceEntities)
		{

		}

        public IEnumerable<tblProduct> GetManufacturerByName(int Product_ID)
        {
            throw new NotImplementedException();
        }
    }
}