using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaPetlje
{
    class Program
    {
        static void Main(string[] args)
        {
            int brc = 0, prosjek = 0;
            Console.WriteLine("Upisite ocjene. Kad ste gotovi upisite 0");
            pogreska:
            int ocjena =Convert.ToInt32( Console.ReadKey());
            
            do {
                
                if (ocjena == 1)
                {
                    Console.WriteLine("Prosjek ocjena je 1 ");
                    goto gotovo;
                }
                if(ocjena<1 || ocjena > 5)
                {
                    Console.WriteLine("Kriva ocena. Probaj opet");
                    goto pogreska;
                }
                prosjek = prosjek + ocjena;
                brc++;
                ocjena = Convert.ToInt32(Console.ReadLine());
            } while (ocjena != 0) ;

            prosjek = prosjek / brc;
            Console.WriteLine("Prosjek ocjena je: "+prosjek);

            gotovo:

            Console.ReadKey();
        }
    }
}
