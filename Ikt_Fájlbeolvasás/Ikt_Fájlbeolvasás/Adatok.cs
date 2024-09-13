using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikt_Fájlbeolvasás
{
    internal class Adatok
    {
        public string szam;
        public string keresztnev;
        public string vezeteknev;

        public string Szam { get => szam; set => szam = value; }
        public string Keresztnev { get => keresztnev; set => keresztnev = value; }
        public string Vezeteknev { get => vezeteknev; set => vezeteknev = value; }

        public Adatok(string szam, string keresztnev, string vezeteknev)
        {
            this.Szam = szam;
            this.Keresztnev = keresztnev;
            this.Vezeteknev = vezeteknev;
        }
    }
    

}
