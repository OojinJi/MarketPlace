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
	public UserRepository : GenericRepository<User>, IUserRepository
	{
		//
		// TODO: Add constructor logic here
		//
		public UserRepository(MarketPlaceEntities marketPlaceEntities): base(marketplaceEntities)
		{ 
			
		}

		public TestDBEntities TestDBEntities 
		{
			get { return Context as marketplaceEntities; }
		}
	}
}