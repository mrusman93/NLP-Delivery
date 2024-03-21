using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_NLP.Common
{
    public abstract class BaseEntity
    {
        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastModifiedDate {  get; set; }
        
        public string LastModifiedby { get; set; }
    }
}
