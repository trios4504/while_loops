using System;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool runLoop = true;

            //we are printing out all the even numbers
            // between 0 and 10
            int counter = 0;
            while (counter <= 10)
            {
                /*
                if(counter % 2 == 0)
                {
                    Console.WriteLine($"{counter} is an even number");
                }
                */

                if (counter % 2 == 1)
                {
                    Console.WriteLine($"{counter} is an odd number");
                }
                counter++;
            }
        }
    }
}
