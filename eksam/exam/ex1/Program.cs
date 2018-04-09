using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          Luua programm mis küsib inimeste nimesi niikaua kuni sisestatakse 
          erimärk „-1“. Iga sisestatud nimi lisatakse massiivi mis kuvatakse 
          kasutajale programmi lõpus välja.Kindlasti tuleb veenduda, et esimene
          täht oleks suur.Selle võid lahendada nii, et palud kasutajal sisestada
          sisendi õigel kujul või siis vaikimisi teed programmis esimese tähe alati suureks.
          */

            Console.WriteLine("See programm jätab meelde sinu kirjutatud nimed ja kirjutab nad suure tähega.");
            Console.WriteLine();
            Console.WriteLine("Lõpetamiseks ja tulemuse nägemiseks vajuta \"-1\"");

            List<string> nimed = new List<string>();



            while (true)
            {
                Console.Write("Kirjuta siia nimi: ");

                string input = Console.ReadLine();

                if (input == "-1")
                {
                    Console.WriteLine("EXIT\n\nSinu nimi(ed):");
                    break;
                }
                else if (input == "")
                {
                    Console.WriteLine("Sa ei kirjutanud mitte ühtegi nime, proovi uuesti");
                }
                else
                {
                    Console.WriteLine($"\nSinu kirjutatud nimi: {input}");
                    nimed.Add(input);



                    Console.WriteLine();
                }
            }
            //https://msdn.microsoft.com/en-us/library/system.globalization.textinfo.totitlecase(v=vs.110).aspx
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            foreach (var nimi in nimed)
                Console.WriteLine("Sinu sisestatud nimi: {0} --> Parandatud nimi: {1}", nimi, ti.ToTitleCase(nimi));



            Console.ReadLine();

        }
    }
}
