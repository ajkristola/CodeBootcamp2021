using System;
using System.IO;

namespace FileSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables

            string filename = @"numbers.txt";
            string[] lines = File.ReadAllLines(filename);

            int sum = 0;
            int currentLine = 1;

            // Loops through each line and parses them into new int 'value' that changes.
            // Then adds the value to 'sum' and loops again to retrieve the new line value. Get me?

            foreach (string line in lines)
            {
                try
                {
                    int value = int.Parse(line);
                    sum += value;
                }
                catch
                {
                    Console.WriteLine("Could not read line \"" + line + "\" on line "
                                        + currentLine + ", not a number.");
                }
                currentLine++;
            }



            /* TryParse method
            ------------------
            using System.Runtime;
            
            foreach (string line in lines)
            {
                int value;

                bool success = int.TryParse(line, out value);
                if (success)
                {
                    sum += value;
                }
                else
                {
                    Console.WriteLine("Cannot process line " + currentLine +
                                        " with value \"" + line + "\", not a valid number.");
                }

                currentLine++;
            }
            */

            Console.WriteLine("Calculated sum: " + sum);

        }
    }
}