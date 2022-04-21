using MarketPlace.DataLayer;
using MarketPlace.RepoLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.RepoLayer.Repositorys
{
    public class ManufacturerRepository : GenericRepository<tblManufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(DbContext context) : base(context)
        {
        }
    }
}