using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Cruel World!");
            Console.Write("The date is " + DateTime.Now.ToString("MM/dd/yyyy") + ". ");
            Console.WriteLine("The time is " + DateTime.Now.ToString("HH:mm") + ".");
        }
    }
}
