using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaVjezbaPetlje
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocjena, zbrojO=0;
            float prosjek, brc=0;

            do
            {
                Console.WriteLine("Upisite ocjenu: ");
                ocjena = Convert.ToInt32(Console.ReadLine());
                if (ocjena == 1)
                {
                    prosjek = 1;
                    break;
                }
                else if (ocjena > 5 || ocjena < 0)
                {
                    Console.WriteLine("Pogresan unos ocjene. Unesite ponovo.");
                }
                else if (ocjena != 0)
                {
                    zbrojO += ocjena;
                    brc++;
                }
                prosjek = zbrojO / brc;

            } while (ocjena != 0);

            Console.WriteLine("Prosjek ocjena je: "+prosjek);



            Console.ReadKey();
        }
    }
}
