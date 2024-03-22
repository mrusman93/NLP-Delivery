using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Domain.Models
{
    public class UserRoles
    {
        [Key]
        public int RoleID { get; set; }

        public string RoleName { get; set; }
    }
}
