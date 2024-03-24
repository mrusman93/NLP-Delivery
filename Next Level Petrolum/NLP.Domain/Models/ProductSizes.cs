using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Domain.Models
{
    public class ProductSizes
    {
        [Key]
        public int SizeID { get; set; }

        public string SizeName { get; set; }

        public string SizeDescription { get; set; }

        public int ProductID { get; set; }

        public Products Product {  get; set; }
    }
}
