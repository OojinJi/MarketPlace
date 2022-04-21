using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.DataLayer;
namespace MarketPlace.RepoLayer.Repositorys
{
    public interface ITypeFilterRepository
    {
        IEnumerable<tblProduct> GetProductByID(int Product_ID);
        IEnumerable<tblSubCategory> GetSubCategoryByID(int SubCategory_ID);
    }
}
