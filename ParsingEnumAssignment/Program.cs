using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumAssignment
{
    class Program
    {
        //enum for days of the week
        enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

        static void Main(string[] args)
        {
            try
            {
                //use enter the current day
                Console.WriteLine("Enter the current day of the week:");
                string userInput = Console.ReadLine();

                //parse user input to enum
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                //display current day
                Console.WriteLine("You entered: " + currentDay);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}
