using Marketplace.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
public class MarketPlace.RepoLayer.Repositorys
{
	public ManufacturerRepository : GenericRepository<Manufacturer>, IManufacturerRepository
	{
		//
		// TODO: Add constructor logic here
		//
		public ManufacturerRepository(MarketPlaceEntities marketPlaceEntities): base(marketplaceEntities)
		{

		}

		public TestDBEntities TestDBEntities
		{
		get { return Context as marketplaceEntities; }
		}
	}
}