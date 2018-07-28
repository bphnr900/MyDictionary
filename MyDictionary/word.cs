using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyDictionary
{
    public class word
    {
        public int WordId { get; set; }
        public string Word { get; set; }
        public string SpecificName { get; set; }
        public type type { get; set; }
    }
}
