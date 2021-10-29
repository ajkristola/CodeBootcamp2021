using System;

namespace ClassesDemo
{
    class Passenger
    {
        public int CurrentSpeed { get; set; }
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