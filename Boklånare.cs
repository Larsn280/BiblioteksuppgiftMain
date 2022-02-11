using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteksuppgiftMain
{
    internal class Boklånare
    {
        
        public string FörNamn { get; set; }
        public string EfterNamn { get; set; }
        public string LåneKort { get; set; }
        public ICollection<Utlåningar> Utlåningar { get; set; } = new List<Utlåningar>();
        
    }
}
