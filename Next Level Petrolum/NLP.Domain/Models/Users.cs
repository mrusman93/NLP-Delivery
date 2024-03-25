using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace NLP.Domain.Models
{
    public class Users : IdentityUser
    {
        //[Key]
        //public int UserID { get; set; }

        //public string Username { get; set; }

        //public string EmailID { get; set; }

        //public string Password { get; set; }

        //public string PhoneNumber { get; set; }

        //public List<UserRoles> Role { get; set; }

    }
}
