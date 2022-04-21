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
	public class CredentialRepository : GenericRepository<tblCredential>, ICredentialRepository
	{
		//
		// TODO: Add constructor logic here
		//
		public CredentialRepository(MarketPlaceEntities1 marketPlaceEntities): base(marketPlaceEntities)
		{

		}

		//public TestDBEntities TestDBEntities
		//{
		//	get { return Context as marketplaceEntities; }
		//}
	}
}