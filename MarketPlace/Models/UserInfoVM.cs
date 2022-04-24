using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarketPlace.Models
{
    public class UserInfoVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public byte[] Image { get; set; }
     
        public string UserType { get; set; }
    }
}