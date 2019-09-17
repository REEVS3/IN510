using System;

namespace Variables
{
    class WhoRU
    {
        static void Main()
        { 
            //Declaring Variables
            int age;
            int daysalive;
            int hoursalive;
            string temp;
            

            //ask for and read in data
            Console.Write("How old are you?");
           temp= Console.ReadLine();

           age = Convert.ToInt32(temp);

            daysalive = age * 365;
            hoursalive = daysalive * 24;




            //Writing data in variables to the screen  
            Console.WriteLine("Hello do you know you have been alive for " +daysalive+  " Days");
            Console.WriteLine("You Also have been alive for " + hoursalive+ " Hours");
        
        
            Console.ReadLine();

           

        }
    }
}
