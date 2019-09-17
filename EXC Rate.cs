using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC_Rate
{
    class Program
    {
        static void Main()

        {  const double AUD = 0.8085, USD = 0.8272, GBP = 0.5457, JPY = 76.23, EUR = 0.6297;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double NZD;

            Console.Write("Input NZD:");
            NZD=Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine($"AUD={NZD*  AUD:C}");
            Console.WriteLine($"USD={NZD * USD:C}");
            Console.WriteLine($"GBP=£{NZD * GBP}");
            Console.WriteLine($"JPY=¥{NZD * JPY}");
            Console.WriteLine($"EUR=€{NZD * EUR}");

            Console.ReadLine();
     
        }
    }
}
