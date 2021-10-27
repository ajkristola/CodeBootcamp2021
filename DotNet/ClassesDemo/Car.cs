using System;

namespace ClassesDemo
{
    class Car
    {
        //properties (data)
        public string Doors { get; set; }
        public string Body { get; set; }
        public string Model { get; set; }
        public int CurrentSpeed { get; set; }
        public int TopSpeed { get; set; }


        // methods (functionality)
        public void Print()
        {
            Console.WriteLine("Car type: " + Doors + Body + Model);
        }
        public void Accelerate()
        {
            CurrentSpeed += 20;
            
            if (CurrentSpeed > TopSpeed) 
            {
                CurrentSpeed = TopSpeed;
            }

            Console.WriteLine("Current speed is: {0}", CurrentSpeed);

        }
    }
}