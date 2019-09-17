using System;
using System.Threading;



namespace Shark_and_swimmer
{
    class Program
    {
        static void Main()
        {
            int Shark = 100, Swimmer = 90;
            Random rand = new Random();











            while ((Swimmer > 0) && (Shark - Swimmer > 0))
            {

                if (Swimmer <= 0)
                {
                    Swimmer = 0;

                }



                Swimmer = Swimmer - rand.Next(10);
                Shark = Shark - rand.Next(10);
                Console.WriteLine($"The Swimmer is {Swimmer} meters from the shore ");
                Console.WriteLine($"The Shark is {Shark - Swimmer} meters from the swimmer");
                Thread.Sleep(700);
                Console.WriteLine();
                Console.WriteLine();

            }


            if (Swimmer <= 0)

            {
                Console.WriteLine("You Got To Saftey");


            }


            else
            {

                Console.WriteLine("The Shark Ate You");

            }


            Console.ReadLine();



        }
    }
}
