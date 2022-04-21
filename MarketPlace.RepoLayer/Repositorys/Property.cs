using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.RepoLayer.Repositorys
{
    public class Property : GenericRepository<Property>, IPropertyRepository
    {
        public Property(DbContext context) : base(context)
        {
        }

        public IEnumerable<tblTechSpecFilter> GetTechSpecFilter(int Property_ID)
        {
            return (IEnumerable<tblTechSpecFilter>)Context.Set<tblProduct>().Find(Property_ID);
        }

        public IEnumerable<tblTypeFilter> GetTypeFilter(int Property_ID)
        {
            return (IEnumerable<tblTypeFilter>)Context.Set<tblTypeFilter>().Find(Property_ID); ;
        }
    }
}
