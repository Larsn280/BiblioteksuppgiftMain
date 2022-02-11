using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BiblioteksuppgiftMain
{
    internal class BöckerOchFörfattare
    {

        public string Isbn { get; set; }
        public string _Författare { get; set; }

        public Författare Författare { get; set; }
        public Book Book { get; set; }

        
    }
}

