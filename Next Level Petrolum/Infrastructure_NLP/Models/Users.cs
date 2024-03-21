using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure_NLP.Common;

namespace Infrastructure_NLP.Models
{
    public class Users : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required]
        public int RoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string? Username { get; set; }

        [Required]
        [StringLength(50)]
        public string? EmailID { get; set; }

        [Required]
        [StringLength(100)]
        public string? Password { get; set; }

        [Required]
        [StringLength(100)]
        public string? PhoneNumber { get; set; }

        [ForeignKey("RoleID")]
        public UserRoles Role { get; set; }
    }
    /*
    public class AppUserViewModel
    {
        public int UserID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int RoleID { get; set; }

        [Required]

        public string EmailID { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    
    }
    */
}
