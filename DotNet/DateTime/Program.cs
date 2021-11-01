using System;

namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        { 
            // string longDateString = myDate.ToLongDateString("yyyyMMddHHmmss");
            // Console.WriteLine("Date: " + longDateString);

            // DateTime dateNow = DateTime.Now;
            // DateTime dateThen = new DateTime(2021, 10, 25, 9, 34, 00);

            // Console.WriteLine("Current time: " + dateNow);
            // Console.WriteLine("Days dateNow.Subtract(dateThen).TotalDays");

            // read the dates from the user
            Console.WriteLine("Enter the first date: ");
            string value = Console.ReadLine();
            DateTime date1 = DateTime.Parse(value);

            Console.WriteLine("Enter the second date: ");
            value = Console.ReadLine();
            DateTime date2 = DateTime.Parse(value);

            // date calculations
            TimeSpan difference = date2 - date1;
            Console.WriteLine(difference.TotalDays);
            Console.WriteLine(difference.TotalHours);
            // Console.WriteLine(date2.Subtract(date1).TotalDays);
        }
    }
}


// Notes
/* Fix culture. Otherwise works. */