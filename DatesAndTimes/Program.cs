using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //To Print Current Date and Time
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            //To Print Current Date Only
            Console.WriteLine(myValue.ToShortDateString());
            //To Print Current Time Only
            Console.WriteLine(myValue.ToShortTimeString());
            //To Print Current  Full Date
            Console.WriteLine(myValue.ToLongDateString());
            //To Print Current Full Time
            Console.WriteLine(myValue.ToLongTimeString());

            //To add days in the Current days
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //To add Hours in the Current days Time
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            //To Subtract days from the Current day
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //To display Current Month
            Console.WriteLine(myValue.Month);

            DateTime myBirthDate = new DateTime(1982 , 02, 24);
            Console.WriteLine(myBirthDate.ToShortDateString());

            // Convert String in to DateTime
            DateTime myBirthday = DateTime.Parse("24/02/1982");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

        }
    }
}
