using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace del1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dates = new List<string>(
                "01.02.1980", "04.04.2004", "03.05.2003", "01.08.1946", "07.01.1908", "14.10.1970", "01.10.1946",
                "02.02.1929", "03.03.1971", "01.12.1913", "01.09.2011", "08.01.1940", "02.01.1991", "18.07.1937",
                "02.03.1941", "01.01.1930", "11.12.2000", "01.10.1995", "01.02.1967", "01.09.1994", "06.06.1913",
                "01.12.1985", "01.01.1932", "10.01.1936", "12.11.1949", "01.03.1972", "15.04.1998", "05.06.2013",
                "31.01.1959", "01.01.1957");
           

            var count = dates.Count;
            double temp = 0D;
            for (int i = 0; i < count; i++)
            {
                temp += dates[i].Ticks / (double)count;
            }
            var average = new DateTime((long)temp);

        }
    }
}
