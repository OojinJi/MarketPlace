using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.RepoLayer.Repositorys
{
    public class PropertyRepository : GenericRepository<PropertyRepository>, IPropertyRepository
    {
        public PropertyRepository(MarketPlaceEntities1 marketPlaceEntities) : base(marketPlaceEntities)
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
