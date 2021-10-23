using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking for input and converting string to int.
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many days until your next birthday?");
            int daysLeft = Convert.ToInt32(Console.ReadLine());


            // Correct until a person turns 100. Afterwards displays apologetic message.
            // Figure out if age - 1 would work after 100, even in the coming years.
            int leapDays = age / 4 + 1;
            int total = ((age + 1) * 365) - daysLeft + leapDays;

            if (age >= 100) {
                Console.WriteLine("Sorry! In awe of your impressive lifespan, my math fails.");
            }
            else {
                Console.WriteLine("You are {0} years old. Assuming there were {1} leap days, that is {2} days.", age, leapDays, total);
            }
        }
    }
}

// Notes: Counting days is inconvenient, find a way to do this. 