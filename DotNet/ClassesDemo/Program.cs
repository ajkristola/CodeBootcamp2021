using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        // 'Car' is a class, 'first' is an instance.
            Car first = new();
            first.Doors = "2-door ";
            first.Body = "convertible ";
            first.Model = "Mazda";
            first.CurrentSpeed = 50;
            first.TopSpeed = 180;
            first.Print();
            first.Accelerate();
            Console.WriteLine("----------------");

            Car second = new();
            second.Doors = "4-door ";
            second.Body = "hatchback ";
            second.Model = "Toyota";
            second.CurrentSpeed = 70;
            second.TopSpeed = 160;
            second.Print();
            second.Accelerate();

            string[] colors = {"red", "blue", "green", "tan"};
            char[] charset = { 'C', 'G', 'J', 'A', 'M' };
            Array.Sort(charset);

            Passenger Mike = new();
            Mike.CurrentSpeed = second.CurrentSpeed;
            Console.WriteLine("The passenger is riding the {0}", second.Model);
            Mike.Mood();

            Console.WriteLine("Rev the engine? y/n");
        // Console.ReadLine(""); Integrate y/n functionality
        }
    }
}
