using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ülesanne 4 Programmis on defineeritud masiiv mis sisaldab umbes 30 erinevat timestamp’i, 
            mis illustreerivad inimeste sünniaega, näiteks vahemikus alates 1940 – 2010.
            Programmi ülesanne on leida nende timestamp’ide põhjal: *maksimaalne vanus *keskmine vanus aastates 
                *minimaalne vanus *millisel kuul on kõige rohkem sünnipäevi kõik *timestamp’id sorteerituna kasvavalt
                */

            string[] timeStampid = new string[30] 
            {
                "01.02.1980", "04.04.2004", "03.05.2003", "01.08.1946", "07.01.1908", "14.10.1970", "01.10.1946",
                "02.02.1929", "03.03.1971", "01.12.1913", "01.09.2011", "08.01.1940", "02.01.1991", "18.07.1937",
                "02.03.1941", "01.01.1930", "11.12.2000", "01.10.1995", "01.02.1967", "01.09.1994", "06.06.1913",
                "01.12.1985", "01.01.1932", "10.01.1936", "12.11.1949", "01.03.1972", "15.04.1998", "05.06.2013",
                "31.01.1959", "01.01.1957"
            };
            string arrayString = string.Join(", ", timeStampid);
            Console.WriteLine(arrayString);
            Console.WriteLine();

            Console.WriteLine("Siin on timeStampid vahemikus 1900-2017");
            
            DateTime hetkeAeg = DateTime.Now;
            Console.WriteLine("Aeg hetkel on : " + hetkeAeg);

            //*maksimaalne vanus* keskmine vanus aastates
            //*minimaalne vanus* millisel kuul on kõige rohkem sünnipäevi kõik *timestamp’id sorteerituna kasvavalt

            // int result = DateTime.Compare(timeStampid);
            for (int i = 0; i < arrayString.Length; i++)
            {
                if (true)
                {

                }
            }

            foreach (var ajaM2rk in timeStampid)
            {
               
                
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();


        }
    }
}
