using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace korcsolya
{
    class Program
    {
        static List<versenyzo> rovidprogram = new List<versenyzo>();
        static List<versenyzo> donto = new List<versenyzo>();

        static void rovidbeolvasas()
        {
            StreamReader sr = new StreamReader("rovidprogram.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');
                rovidprogram.Add(new versenyzo(adat[0], adat[1], double.Parse(adat[2].Replace(".", ",")), double.Parse(adat[3].Replace(".", ",")), double.Parse(adat[4])));
            }
            sr.Close();

        }


        static void dontobeolvasas()
        {
            StreamReader sr = new StreamReader("rovidprogram.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] adat = sr.ReadLine().Split(';');
                donto.Add(new versenyzo(adat[0], adat[1], double.Parse(adat[2].Replace(".", ",")), double.Parse(adat[3].Replace(".", ",")), double.Parse(adat[4])));
            }
            sr.Close();

        }

        static void masodik()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine($"\t A rövid programban {rovidprogram.Count()} induló volt");
        }

        static void harmadik()
        {
            Console.WriteLine("3.feladat");
            foreach (var t in donto)
            {
                if (t.Orszag.Contains("HUN"))
                {
                    Console.WriteLine("A magyar versenyző bejutott a döntőbe");
                }
            }

         
        }

        static void OsszPontszam()
        {

            foreach (var t in rovidprogram)
            {
                
            }
        }


        static void otos()
        {
            Console.WriteLine("5. feladat");
            Console.WriteLine("Kérem a versenyző nevét: ");
            string nev = Console.ReadLine();
            bool van = false;
            int i = 0;
            while (i < rovidprogram.Count)
            {
                if (rovidprogram[i].Nev == nev)
                {
                    van = true;
                }
                i++; 
            }
            if (!van)
            {
                Console.WriteLine("Ilyen nevű játékos nincsen");
            }
            
            
        }

        static void hatos()
        {

        }

        static void hetes()
        {

        }

        static void nyolcas()
        {

        }

        static void Main(string[] args)
        {
            rovidbeolvasas();
            dontobeolvasas();
            masodik();
            harmadik();
            OsszPontszam();
            otos();
            hatos();
            hetes();
            nyolcas();


            Console.ReadKey();
        }
    }
}
