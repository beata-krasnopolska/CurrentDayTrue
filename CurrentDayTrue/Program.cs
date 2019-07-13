using System;

namespace CurrentDayTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program checks whether the given year, month and day are the current or not.");

            Console.WriteLine("Enter the day: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter th year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime givenDate = new DateTime(year, month, day);

            //DateTime givenDate = new DateTime(2019, 1, 1);
            DateTime today = DateTime.Today;

            if (today == givenDate)
            {
                Console.WriteLine("The given date is current day. Today is {0}", today);
            }
            else
            {
                Console.WriteLine("The given date  is not today. Today is {0}", today);
            }
            Console.ReadKey();
        }
    }
}
