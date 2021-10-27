using System;
using System.IO;

namespace NumCounter
{
    class JaniProgram
    {
        static void Main(string[] args)
        {
            string filename = @"/source/code_bootcamp/DotNet/NumCounter/numbers.txt";
            string[] lines = File.ReadAllLines(filename);

            int sum = 0;
            foreach (string line in lines)
            {
                int value = int.Parse(line);
                sum += value;
            }
        
            Console.WriteLine("Calculate sum is: " + sum);
        }    
    }
}
