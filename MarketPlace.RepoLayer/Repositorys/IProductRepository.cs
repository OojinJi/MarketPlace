using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace MarketPlace.RepoLayer.Repositorys
{
	public interface IProductRepository
	{
		IEnumerable<tblProduct> GetManufacturerByName(int Product_ID);
	}
}
