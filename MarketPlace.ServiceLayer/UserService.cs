using MarketPlace.DataLayer;
using MarketPlace.RepoLayer.Repositorys;
using MarketPlace.ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.ServiceLayer
{
    public class UserService
    {
       

        public UnitOfWork uow { get; set; }
        public UserService()
        {
            MarketPlaceEntities1 marketPlaceEntities = new MarketPlaceEntities1();
            uow = new UnitOfWork(marketPlaceEntities);
        }

        public IEnumerable<UserDTO> UserInfoByID(string name, int id)
        {
            var Users = uow.Users.GetAll();
            var Credentials = uow.Credentials.GetAll();
            var result = (from u in Users 
                          join c in Credentials on u.Credential_ID equals c.Credential_ID
                          where u.User_ID == id
                          select new UserDTO
                          {
                              Id = u.User_ID,
                              Name = u.User_Name,
                              Email = u.User_Email,
                              Image = u.User_Image,
                              Password = u.User_Password,
                              UserType = c.User_Type

                          }).ToList();
            return result;
        }
    }
}
