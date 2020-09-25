using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {

        static List<Termek> termekek = new List<Termek>();
        static List<Megrendeles> rendeles = new List<Megrendeles>();
        static void beolvas_raktar()
        {
            StreamReader sr = new StreamReader("raktar.csv");
            
            while (!sr.EndOfStream) 
            {
                /*
                 sor[0] -> kod
                 sor[1] -> ár stb 
                 
                 */
                string[] sor = sr.ReadLine().Split(';');
                
                termekek.Add(new Termek(sor[0], sor[1],int.Parse(sor[2]),int.Parse(sor[3])));
                
            }

            sr.Close();
            //Console.WriteLine(termekek[0].Nev);


            //for (int i = 0; i < termekek.Count; i++)
            //{
            //    Console.WriteLine(termekek[i].KOD);
            //}
        }


        static void rendeles_beolv()
        {
            StreamReader sr = new StreamReader("rendeles.csv");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] adat = sor.Split(';');
                if (adat[0] == "M")
                {
                    rendeles.Add(new Megrendeles(adat[1], adat[2], adat[3]));
                }
                else
                {
                    //rendeles[rendeles.Count - 1].termekek.Add(sor);
                    rendeles[rendeles.Count - 1].TetelHozzaad(adat[2],int.Parse(adat[3]));
                }
                


            }
            sr.Close();
           //for (int i = 0; i < rendeles.Count; i++)
           // {
           //     Console.WriteLine(rendeles[i].EMAIL);
           // }
        }



        static void Main(string[] args)
        {
            //beolvas_raktar();
            for (int i = 0; i < termekek.Count; i++)
            {
                Console.WriteLine(termekek[i].Nev,termekek[i].AR);
            }

            rendeles_beolv();

            
            Console.ReadKey();
        }
    }
}
