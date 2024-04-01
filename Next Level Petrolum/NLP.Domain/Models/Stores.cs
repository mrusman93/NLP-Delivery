using System.ComponentModel.DataAnnotations;

namespace NLP.Domain.Models
{
    public class Stores
    {
        [Key]
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public List<Brands> Brand { get; set; }
        public List<Addresses> Address { get; set; }
    }
}
