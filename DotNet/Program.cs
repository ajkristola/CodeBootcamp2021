using System;
using System.Linq;
using System.IO;

namespace NumCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = System.IO.File.ReadLines(@"/source/code_bootcamp/DotNet/NumCounter/numbers.txt");
            Console.WriteLine(data);

            // Console.WriteLine(data.GetType());

            /*int sum = 0;
            foreach (string line in File.ReadLines(@"/source/code_bootcamp/DotNet/NumCounter/numbers.txt")) {
                sum += int.Parse(line);
            
            Console.WriteLine("The sum is {0}", sum);
            } */
        }
    }
}
