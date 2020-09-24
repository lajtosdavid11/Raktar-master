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
                Console.WriteLine(sor[0]);
                
                
                termekek.Add(new Termek(sor[0], sor[1],int.Parse(sor[2]),int.Parse(sor[3])));
                


            }

            sr.Close();


            for (int i = 0; i < termekek.Count; i++)
            {
                Console.WriteLine(termekek[i].KOD);
            }
        }
        static void Main(string[] args)
        {
            beolvas_raktar();
            


            Console.ReadKey();
        }
    }
}
