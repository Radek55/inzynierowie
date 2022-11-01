using AplikacjaInzynierka.Wprowadzenie;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaInzynierka.Badanie.Zapisywanie
{
    internal class ZapisDanych 
    {
        public void ZapisLokalnie(string path, string name, Dictionary<string, int> dict)
        {

            File.WriteAllLines(path + ""+ name +".txt", dict.Select(x => x.Key + " : " + x.Value).ToArray());
        }

        //public bool ZapisBaza()
    }
}
