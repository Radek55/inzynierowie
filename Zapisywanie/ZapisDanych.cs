using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaInzynierka.Badanie.Zapisywanie
{
    internal class ZapisDanych
    {
        public bool ZapisLokalnie()
        {
            File.WriteAllTextAsync("WriteText.txt", "siema");
            return true;
        }

        //public bool ZapisBaza()
    }
}
