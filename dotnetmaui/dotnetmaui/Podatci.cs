using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetmaui
{
    public class Podatci
    {
        public string Ime {  get; set; }
        public string Status { get; set; }
        public string Slika { get; set; }

        public Podatci (string ime, string status, string slika)
        {
            Ime = ime;
            Status = status;
            Slika = slika;
        }
    }
}
