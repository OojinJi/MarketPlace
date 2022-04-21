using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.RepoLayer.Repositorys
{
    public interface IPropertyRepository
    {
        IEnumerable<tblTechSpecFilter> GetTechSpecFilter(int Property_ID);
        IEnumerable<tblTypeFilter> GetTypeFilter(int Property_ID);
    }
}
