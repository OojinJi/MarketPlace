using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketPlace.Models
{
    public class UserInfoVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}