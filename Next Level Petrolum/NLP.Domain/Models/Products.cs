using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Domain.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }
        [ForeignKey("BrandID")]
        public Brands Brand { get; set; }
        [ForeignKey("SizeID")]
        public ProductSizes Size { get; set; }
    }
}
