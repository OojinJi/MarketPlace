using MarketPlace.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace MarketPlace.RepoLayer.Repositorys
{
	public class UserRepository : GenericRepository<tblUser>, IUserRepository
	{
		//
		// TODO: Add constructor logic here
		//
		public UserRepository(MarketPlaceEntities1 marketPlaceEntities): base(marketPlaceEntities)
		{ 
			
		}

	}
}