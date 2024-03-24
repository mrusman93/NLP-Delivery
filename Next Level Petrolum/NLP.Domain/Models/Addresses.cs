using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Domain.Models
{
    public class Addresses
    {
        [Key]
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int StoreID { get; set; } 
        public Stores Store { get; set; }
    }
}
