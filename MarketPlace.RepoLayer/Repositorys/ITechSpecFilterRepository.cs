using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.RepoLayer.Repositorys
{
    public interface ITechSpecFilterRepository
    {
       IEnumerable<tblProduct> GetProductByID(int Product_ID);
       IEnumerable<tblSubCategory> GetSubCategoryByID(int SubCategory_ID);
    }
}
