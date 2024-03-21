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
        public int StoreID { get; set; }

        public string StoreName { get; set; }

        public List<Brands> Brand { get; set; }

        public Addresses Address { get; set; }
    }
}
