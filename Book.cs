using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteksuppgiftMain
{
    internal class Book
    {
        
        public string Isbn { get; set; }
        public string _BokTitle { get; set; }
        public int UtgivningsÅr { get; set; }
        public int Betyg { get; set; }
        public int AntalILager { get; set; }

        public ICollection<BöckerOchFörfattare> BöckerOchFörfattare { get; set; } = new List<BöckerOchFörfattare>();
        public ICollection<Utlåningar> Utlåningar { get; set; } = new List<Utlåningar>();

    }
}
