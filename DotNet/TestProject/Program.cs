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

// Notes: 
// Counting days is inconvenient, find an alternative way to do this. 
// Andrej: make a dict with months and iterate through it until you hit the correct index,
// then go back a month then add date
// So make an array with the months equivalent to dates, go through it, then minus one month, plus days. 
// Another problem: how do I read numbers from a date (string)?