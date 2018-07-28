using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyDictionary
{
    public class type
    {
        public int typeId { get; set; }
        public string typeName { get; set; }

        public virtual ICollection<word> Words { get; set; }
    }
}
