using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.RepoLayer.Repositorys
{
    public class Category : GenericRepository<Category>, ICategoryRepository
    {
        public Category(DbContext context) : base(context)
        {
        }
    }
}
