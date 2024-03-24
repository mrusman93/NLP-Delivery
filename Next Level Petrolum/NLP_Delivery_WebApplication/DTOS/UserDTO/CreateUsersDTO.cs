using NLP.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NLP_Delivery_WebApplication.DTOS.UserDTO
{
    public class CreateUsersDTO
    {
        public int UserID { get; set; }

        public string Username { get; set; }

        public string EmailID { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public List<UserRoles> Role { get; set; }
    }
}
