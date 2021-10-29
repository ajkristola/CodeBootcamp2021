using System;

namespace ClassesDemo
{
    class Car
    {
        // Creating a constructor to save on code
        public Car(string NumDoors, string typeBody, string typeModel)
        {
            Doors = NumDoors;
            Body = typeBody;
            Model = typeModel;
        }
        // Properties/Fields (data)
        public string Doors;
        public string Body { get; set; }
        public string Model { get; set; }
        public int CurrentSpeed { get; set; }
        public int TopSpeed { get; set; }


        // Methods (functionality)
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