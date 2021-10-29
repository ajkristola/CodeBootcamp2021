using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        // 'Car' is a class, 'first' is an instance.
            Car first = new Car("2-door ", "convertible ", "Mazda");
            first.Print();
            Console.WriteLine("----------------");

            Car second = new Car("4-door ", "hatchback ", "Toyota ");
            second.CurrentSpeed = 70;
            second.TopSpeed = 160;
            second.Print();
            second.Accelerate();

            Passenger Mike = new();
            Mike.CurrentSpeed = second.CurrentSpeed;
            Console.WriteLine("The passenger is riding the {0}", second.Model);
            Mike.Mood();

            Console.WriteLine("Rev the engine? y/n");
        // Console.ReadLine(""); Integrate y/n functionality
        }
    }
}
