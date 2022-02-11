using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteksuppgiftMain
{
    internal class Författare
    {
        
        public string _Författare { get; set; }
        public int FödelseÅr { get; set; }

        public ICollection<BöckerOchFörfattare> BöckerOchFörfattare { get; set; } = new List<BöckerOchFörfattare>();
    }
}
