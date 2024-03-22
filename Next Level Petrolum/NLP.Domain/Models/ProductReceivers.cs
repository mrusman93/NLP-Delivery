using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Domain.Models
{
    public class ProductReceivers
    {
        [Key]
        public int ReceiverID { get; set; }

        public string ReceiverName { get; set; }
        [ForeignKey("AddressID")]
        public Addresses ReceiverAddress { get; set; }

    }
}
