using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_NLP.Models
{
    public class UserHistory 
    {
        [Key]
        public int HistoryID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime LogInTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? LogOutTime { get; set; }

        [ForeignKey("UserID")]
        public Users User { get; set; }
    }
}
