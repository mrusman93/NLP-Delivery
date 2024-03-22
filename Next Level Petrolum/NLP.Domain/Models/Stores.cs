using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Domain.Models
{
    public class Stores
    {
        [Key]
        public int StoreID { get; set; }

        public string StoreName { get; set; }
        [ForeignKey("BrandID")]
        public Brands Brand { get; set; }
        [ForeignKey("AddressID")]
        public Addresses Address { get; set; }
    }
}
