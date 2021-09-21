using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hegyek
{
    class Hegy
    {
        public string hegycsucsneve;
        public string hegyseg;
        public int magassag;

        public Hegy(string hegycsucsneve, string hegyseg, int magassag)
        {
            this.hegycsucsneve = hegycsucsneve;
            this.hegyseg = hegyseg;
            this.magassag = magassag;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string banner;
            List<Hegy> hegylista = new List<Hegy>();
            using (StreamReader sr = new StreamReader("hegyekMo.txt"))
            {
                banner = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] darabok = sr.ReadLine().Split(';');
                    Hegy h = new Hegy(darabok[0], darabok[1], int.Parse(darabok[2]));
                    hegylista.Add(h);
                }
            }

            //3. feladat
            Console.WriteLine("3. feladat: Hegycsúcsok száma: {0} db", hegylista.Count);

            double height_sum = 0;

            foreach (Hegy item in hegylista)
            {
                height_sum += item.magassag;
            }

            //4. feladat
            Console.WriteLine("4. feladat: Hegycsúcsok átlagos magassága: {0} m", (height_sum/hegylista.Count));

            //5. feladat
            int max = hegylista[0].magassag, index_i = 0;

            for (int i = 0; i < hegylista.Count; i++)
            {
                if (hegylista[i].magassag > max)
                {
                    max = hegylista[i].magassag;
                    index_i = i;
                }
            }

            Console.WriteLine("5. feladat: A legmagasabb hegycsúcs adatai:\n\tNév: {0}\n\tHegység: {1}\n\tMagasság: {2} m", hegylista[index_i].hegycsucsneve, hegylista[index_i].hegyseg, hegylista[index_i].magassag);
            
            //6. feladat
            Console.Write("6. feladat: Kérek egy magasságot: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int index_k = 10, k = 0;
            bool quit = true;

            while (quit)
            {
                if (hegylista[k].magassag > input)
                {
                    index_k = k;
                    quit = false;
                }
                k++;
            }

            Console.WriteLine("\tVan {0} m-nél magasabb hegycsúcs a {1}", input, hegylista[index_k].hegycsucsneve);
            Console.ReadLine();
        }
    }
}
