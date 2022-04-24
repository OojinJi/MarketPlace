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
		private readonly MarketPlaceEntities1 _marketPlaceEntities1;
		public UserRepository(MarketPlaceEntities1 marketPlaceEntities1): base(marketPlaceEntities1)
		{
			this._marketPlaceEntities1 = marketPlaceEntities1;
		}

        public string GetPasswordByUsername(string username)
        {
			return _marketPlaceEntities1.tblUsers.Where(u => u.User_Name.ToLower() == username.ToLower()).FirstOrDefault()?.User_Password;
        }
    }
}