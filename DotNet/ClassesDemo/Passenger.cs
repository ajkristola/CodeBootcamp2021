using System;

namespace ClassesDemo
{
    class Passenger : Car
    {
        public void Mood()
        {
            if (CurrentSpeed > 100)
            {
                Console.WriteLine("They are scared");
            }
            else
            {
                Console.WriteLine("They are enjoying themself.");
            }
        }
    }
}

// Notes:
// It doesn't make sense for the passenger to inherit the functionality of car. They are separate entities.
// E.g. a class named SportsCar would make more sense. 