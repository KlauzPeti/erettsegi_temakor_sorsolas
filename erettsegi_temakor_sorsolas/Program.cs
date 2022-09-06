using System;
using System.IO;
using System.Collections.Generic;

namespace erettsegi_temakor_sorsolas
{
    class Program
    {
        static void Main(string[] args)
        { 
            StreamWriter nevSor = new StreamWriter("nevsor.txt");
            {
                nevSor.WriteLine("Biró Barnabás");
                nevSor.WriteLine("Klauz Péter");
                nevSor.WriteLine("Kővári Sándor");
                nevSor.WriteLine("Rajcsányi Zsombor Levente");
                nevSor.WriteLine("Pápai Botond Zsolt");
                nevSor.WriteLine("Szécsényi Máté");
                nevSor.WriteLine("Nyerges Martin");
                nevSor.WriteLine("Kovács Milán");
                nevSor.WriteLine("Kozári Krisztián");
                nevSor.WriteLine("Ignácz Marcell György");
                nevSor.WriteLine("Lóth Görgy");
                nevSor.WriteLine("Fábos Ervin Krisztián");
                nevSor.WriteLine("Mezei Attila");
                nevSor.WriteLine("Lenti János");
                nevSor.WriteLine("Váradi Bertold");
            }
            nevSor.Close();

            List<string> nevek = new List<string>();
            string[] sorok = File.ReadAllLines("nevsor.txt");
            for (int i = 0; i < sorok.Length; i++)
            {
                nevek.Add(sorok[i]);
            }
            List<int> tetelek = new List<int>();
            for (int i = 1; i < 21; i++)
            {
                tetelek.Add(i);
            }

            Random rnd = new Random();

            StreamWriter ir = new StreamWriter("csigidigididédammm");


            for (int i = 0; i < nevek.Count; i++)
            {
                int szam = rnd.Next(0, tetelek.Count);
                Console.WriteLine("{0}: {1}. témakör", nevek[i], tetelek[szam]);
                ir.WriteLine("{0}: {1}. témakör", nevek[i], tetelek[szam]);

                tetelek.RemoveAt(szam);
            }
            for (int i = 0; i < tetelek.Count; i++)
            {
                int szam = rnd.Next(0, nevek.Count);
                Console.WriteLine("{0}: {1}. témakör", nevek[szam], tetelek[i]);
                ir.WriteLine("{0}: {1}. témakör", nevek[szam], tetelek[i]);

                nevek.RemoveAt(szam);
            }
            ir.Close();



            

           

        }
    }
}
