using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TuranBalazsfootgolf
{
    class Program
    {
        static List<Versenyzok> resztvevok;
        static void Main(string[] args)
        {
            Beolvas();
            F03();
            F04();


            Console.ReadKey();
        }
        private static  void F04()
        {




            double nok = resztvevok.Count(a => a.Kategoria.ToLower().Contains("noi"));
            double arany = (nok * 100) / resztvevok.Count();
            Console.WriteLine("f04 : {0:0.00}%", arany);

        }
        private static void F03()
        {
            
                Console.WriteLine($"f03:  {resztvevok.Count}");
             
            
        }

        private static void Beolvas()
        {
            resztvevok = new List<Versenyzok>();
            var sr = new StreamReader(@"C:\Users\Turan\OneDrive\Asztali gép\Juhász doga\TuranBalazsfootgolf\TuranBalazsfootgolf\bin\Debug\fob2016.txt", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                resztvevok.Add(new Versenyzok(sr.ReadLine()));
            }
            sr.Close();

        }
    }
}
