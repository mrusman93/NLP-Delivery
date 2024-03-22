using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP.Domain.Models
{
    public class ProductDispensing
    {
        [Key]
        public int DispensingID { get; set; }

        public DateTime Date { get; set; }

        public int NumProducts { get; set; }

        public byte[] SignatureImage { get; set; }

        public Stores Store { get; set; }

        public Users User { get; set; }

        public ProductReceivers Receiver { get; set; }

        public Products Product { get; set; }

    }
}
