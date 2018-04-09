using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace del
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta siia minimaalne aastaarv");
            string inputminaasta = Console.ReadLine();
            string minaasta = "Jan 1, " + inputminaasta;
            Console.WriteLine(minaasta);
            //DateTime parsedminaasta = DateTime.Parse(inputminaasta);
            int minAastaarv = int.Parse(inputminaasta);
            // string dateInput = "Jan 1, 2009";
            DateTime parsedMin = DateTime.Parse(minaasta);
            Console.WriteLine(parsedMin);

            Console.WriteLine("Sisesta üks suur aastaarv");
            //var maxaasta = int.Parse(Console.ReadLine());
            string inputmaxaasta = Console.ReadLine();
            string maxaasta = "Jan 1, " + inputmaxaasta;
            Console.WriteLine(maxaasta);
            int maxAastaarv = int.Parse(inputmaxaasta);
            //DateTime parsedminaasta = DateTime.Parse(inputmaxaasta);
            DateTime parsedMax = DateTime.Parse(maxaasta);
            Console.WriteLine(parsedMax);

            Console.WriteLine("Sisesta aastaarvude hulk, kuipalju ma Sulle nende vahemikust kuvaksin");
            var i = int.Parse(Console.ReadLine());
            var x = i;
            // var random = new Random((int)DateTime.Now.Ticks);
            // var randomValue = random.Next(startValue, endValue + 1);

            var random = new Random();
            for (i = 0; i < x; i++)
                Console.WriteLine("Jan 1, " + random.Next(minAastaarv, maxAastaarv + 1));

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
