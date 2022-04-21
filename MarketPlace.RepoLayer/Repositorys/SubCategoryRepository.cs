using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.RepoLayer.Repositorys
{
    public class SubCategoryRepository : GenericRepository<tblSubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<tblSubCategory> GetCategoryByID(int Category_ID)
        {
            return (IEnumerable<tblSubCategory>)Context.Set<tblSubCategory>().Find(Category_ID); ;
        }
    }
}
