/*  
1. Used random next function
2. While loop
*/
using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int num = rand.Next(0, 21);
            int i = 0;

            Console.WriteLine("Guess what number I'm thinking of!");

            while (i < 3)
            {
                int userInput = int.Parse(Console.ReadLine());

                if (userInput > num)
                {
                    Console.WriteLine("Try smaller.");
                    i++;
                }
                else if (userInput < num)
                {
                    Console.WriteLine("Try bigger.");
                    i++;
                }
                else
                {
                    Console.WriteLine("Bang on!");
                    break;
                }
            }

            Console.WriteLine("Answer: {0}", num);

        }
    }
}
