using System;

namespace Dice_roller
{
    class Dice
    {
        static void Main()
        {
            int i, dice, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;
            Random rand = new Random();

            for (i = 0; i < 6000; i++)
            {
                dice = rand.Next(1, 7);



                switch (dice)
                {
                    case 1:
                        one++;
                        break;

                    case 2:
                        two++;
                        break;
                    case 3:
                        three++;

                        break;
                    case 4:
                        four++;
                        break;

                    case 5:
                        five++;
                        break;
                    case 6:
                        six++;
                        break;
                    default:
                        break;


                }


            }
            Console.WriteLine("     The Results Are.");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"|Ones:  {one.ToString().PadLeft(20)}|");
            Console.WriteLine($"|Twos:  {two.ToString().PadLeft(20)}|");
            Console.WriteLine($"|Threes:{three.ToString().PadLeft(20)}|");
            Console.WriteLine($"|Fours: {four.ToString().PadLeft(20)}|");
            Console.WriteLine($"|Fives: {five.ToString().PadLeft(20)}|");
            Console.WriteLine($"|Sixes: {six.ToString().PadLeft(20)}|");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();

                }
    }
}
