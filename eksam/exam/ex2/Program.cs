using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ülesanne 2
            Sul on programmis defineeritud massiiv järgnevate nimedega: Kaur, Mattias, Kristel, Heleri, Trevor, 
                                                                        Kristjan, Kelli, Kevin, Maarika, Laura.
            Programm küsib kasutaja käest sisendit. Sisendiks võib olla üks sõna, lause või miks mitte ka 10 lauset. 
            Ülesanne on kasutajale programmi lõpus kuvada tema sisestatud sisend, aga nii, et kõik nimed oleks kindlasti 
            suure algustähega.
             Näiteks kui kasutaja sisestab teksti: „kevin ja heleri mängisid koos liivakastis. trevor vaatas pealt 
            ning kristel kiikus.“ siis tulemuseks peab olema: „Kevin ja Heleri mängisid koos liivakastis. 
            Trevor vaatas pealt ning Kristel kiikus.“ 
          */
            Console.WriteLine("Programm muudab nimel esitähe suureks, kirjuta mingi lause.\n");

            string[] names = {"kaur", "mattias", "kristel", "heleri", "trevor",
                "kristjan","kelli", "kevin", "maarika", "laura"};
            {
                Console.WriteLine("Kasuta neid nimesid: ");
                int i = 0;
                while (i < names.Length)
                {

                    string nimi = names[i];

                    string nimiSuureTähega = char.ToUpper(nimi[0]) + nimi.Substring(1).ToLower();

                    Console.Write(nimiSuureTähega);

                    i += 1;

                    if (i < names.Length)
                    {

                        Console.Write(", ");
                    }
                }
                Console.WriteLine(".");
            }

            Console.WriteLine();

            Console.Write("Kirjuta siia oma lause: ");

            string input = Console.ReadLine();
            


            StringBuilder output = new StringBuilder("", input.Length);

            string[] sõnad = input.Split(' ');

            for (int sõnaIndeks = 0; sõnaIndeks < sõnad.Length; sõnaIndeks += 1)
            {

                string sõna = sõnad[sõnaIndeks];

                if (sõna.Length > 0)
                {

                    StringBuilder sõnaONnimi = new StringBuilder(sõna);

                    

                    if (names.Contains(sõnaONnimi.ToString().ToLower()))
                    {

                        sõnaONnimi[0] = char.ToUpper(sõnaONnimi[0]);

                        for (int j = 1; j < sõnaONnimi.Length; j += 1)
                        {

                            sõnaONnimi[j] = char.ToLower(sõnaONnimi[j]);
                        }
                    }

                    output.Append(sõnaONnimi);
                    output.Append(' ');
                }
            }

            Console.WriteLine();
            Console.WriteLine(output.ToString());
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
                       

        }
    }
}
