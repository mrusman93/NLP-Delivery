using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Domain.Models
{
    public class Brands
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public Byte[] BrandImage { get; set; }        
        public int StoreID { get; set; }
        public Stores Store { get; set; }
    }
}
