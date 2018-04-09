using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ülesanne 3 Proramm küsib kasutaja käest kolme sisendit: 
             a) minimaalne aasta arv, b) maksimaalne aasta arv, c) suvaliselt genereeritavate andmete hulka. 
                 Vastavalt sisestatud andmetele genereeritakse suvaliselt etteantud vahemikus ja hulgal timestamp’e.
                 */

            Console.WriteLine("Proramm küsib kolme sisendit: \n");

            Console.Write("Sisesta siia minimaalne aasta arv: ");
            var minimaalneAasta = Console.ReadLine();

            var algus = "01.01." + minimaalneAasta;
            int algusAastaarv = int.Parse(minimaalneAasta);

            DateTime algusParse = DateTime.Parse(algus);
            Console.WriteLine("Sinu algusaasta: " + algusParse);
            
            Console.WriteLine();


            Console.Write("Sisesta siia maksimaalne aasta arv: ");
            var maksimaalneAasta = Console.ReadLine();

            var l6pp = "01.01." + maksimaalneAasta;
            DateTime l6ppParse = DateTime.Parse(l6pp);
            int viimaneAasta = int.Parse(maksimaalneAasta);
            Console.WriteLine("Sinu lõppaasta: " + l6ppParse);

            Console.WriteLine();

            
            Console.Write("Sisesta siia mitu TimeStampi soovid: ");
            var suvalineArv = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var random = new Random();

           
            for (int i = 0; i < suvalineArv; i++)
            {
                Console.WriteLine("Suvalised TimeStampid sinu antud vahemikust: 01.01." + random.Next(algusAastaarv, viimaneAasta + 1));
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            
        }
    }
}
