using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketPlace.RepoLayer.Repositorys
{
    public interface ISubCategoryRepository
    {
        IEnumerable<tblSubCategory> GetCategoryByID(int Category_ID);
    }
}
