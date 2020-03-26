using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuranBalazsfootgolf
{
    class Versenyzok
    {
        public string Nev { get; set; }
        public string Kategoria { get; set; }

        public string Egyesulet { get; set; }

        public byte[] Pontok{ get; set; }

        public Versenyzok(string s)
        {
            var t = s.Split(';');
            Nev = t[0];
            Kategoria = t[1];
            Egyesulet = t[2];
            Pontok = new byte[8];
            for (int i = 0; i < Pontok.Length; i++)
            {
                Pontok[i] = byte.Parse(t[i + 3]);
            }



        }

    }
}
