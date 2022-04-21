using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.RepoLayer.Repositorys
{
    public class TypeFilterRepository:GenericRepository<TypeFilterRepository>,ITypeFilterRepository
    {
          public TypeFilterRepository(DbContext context) : base(context)
    {

    }


    public IEnumerable<tblProduct> GetProductByID(int Product_ID)
    {
        return (IEnumerable<tblProduct>)Context.Set<tblProduct>().Find(Product_ID);
    }
    public IEnumerable<tblSubCategory> GetSubCategoryByID(int SubCategory_ID)
    {
        return (IEnumerable<tblSubCategory>)Context.Set<tblSubCategory>().Find(SubCategory_ID);
    }
   }
   
}
