using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteksuppgiftMain
{
    internal class Utlåningar
    {
        
        public string Lånekort { get; set; }
        public string Isbn { get; set; }

        public string Lånedatum { get; set; }
        public string Returdatum { get; set; }

        public Book Book { get; set; }
        public Boklånare Boklånare { get; set; }
    }
}
