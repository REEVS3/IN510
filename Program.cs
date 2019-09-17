using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1_Seymour
{
    class Program
    {
        static void Main()
        {

            //  :Seymour Reeves-Boddy
            //  :Programing 1 
            // : Noah Assesment


            // Delclearing Variables
         
            int rain=0,dayCount=1,rainCount=0,totalRain=0,prevRain=0,noRain=0;
            double Average=0;


            Console.WriteLine("Welcome To Noah's Weather Tracker");
            Console.WriteLine("Press Any Key to begin The Tracker when you would like to end it enter 999 for rain fall");

            Console.Clear();


            //Using a While Loop to run untill user input
           
            while (rain != 999)

            {
                Console.WriteLine($"Please Put in The Rain Fall for Day {dayCount}.");
                rain = Convert.ToInt32(Console.ReadLine());

                Average = totalRain / (double)(dayCount-1);

                if (rain<0 )
                {
                    rain =0;
                    Console.WriteLine("That is not a Valid Input Press any key to continue");
                    dayCount--;
                    Console.ReadLine();
                }

                if (rain>0 && rain != 999)
                {

                    rainCount++;
                    dayCount++;
                }

                if (rain > prevRain && rain!=999)
                {
                    prevRain = rain;
                    
                }


                if (rain==0 )
                {
                    dayCount++;
                    noRain++;


                }




                totalRain = totalRain + rain;

              

            }

            //Print Results
            Console.Clear();

            Console.WriteLine("Thank You For using the rain tracker your results are bellow");
            Console.WriteLine();
            Console.WriteLine($"You tracked {rainCount} Days of rainfall");
            Console.WriteLine($"The tracker ran for {dayCount-1} Days");
            Console.WriteLine($"The Average Amount of rain fall for {dayCount-1} Days Was {Average}mm");
            Console.WriteLine($"It didnt rain for a total of {noRain} days");
            Console.WriteLine($"The most rain on any day was {prevRain}mm");


            Console.ReadLine();

















        }
    }
}
