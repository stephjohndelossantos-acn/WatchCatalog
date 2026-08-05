using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise05_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display            
            Console.WriteLine("                 Exercise 5!");
            Console.WriteLine("                 DateTime Logical Skills Program\n");

            //string first, second;
            bool firstvalid = false, secondValid = false;

            //very very important to initialize it first since error if the var has no value
            DateTime firstDate = DateTime.MinValue; 
            DateTime secondDate = DateTime.MinValue;

            //similar with my exercise 04 validation for user input, using a default bool until it activate to true to go out
            while (!firstvalid)
            {
                try
                {
                    //first user input
                    Console.Write("Enter the first date(yyy-MM-dd): ");
                    firstDate = DateTime.Parse(Console.ReadLine());

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e + "Invalid input. Do try again ");
                }
            }
            //second user input for the seconnd date
            while(!secondValid){
                try
                {
                    //secon user input
                    Console.Write("Enter the second date(yyy-MM-dd): ");
                    secondDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e + "Invalid input. Do try again ");
                }
            }
            //swap if case is second date is bigger than firstdate
            if(firstDate > secondDate)
            {
                //temporary var for swapping
                DateTime i = firstDate;
                firstDate = secondDate;
                secondDate = i;
            }
            //counting for M-F, Weekends
            int weekends = 0, weekdays = 0;

            
            DateTime first;
            //initialize our very first date as the very first of our iteration
            
            for(first = firstDate; first <= secondDate; first = first.AddDays(1))
            {

                //our counting for date comparing and classifying each date


                //everytime we encounter weekdends, we count or increment the weekends since there are only 2 kaysa sa weekdays
                if (first.DayOfWeek == DayOfWeek.Saturday || first.DayOfWeek == DayOfWeek.Sunday)
                {
                    weekends++;
                }
                //Monday through friday coutning
                else
                {
                    weekdays++;
                }
            }
            
            int totalDay = (secondDate - firstDate).Days + 1;

            //print print
            Console.WriteLine($"Between {firstDate:yyyy-MM-dd} and {secondDate:yyyy-MM-dd}:");

            Console.WriteLine("Weekdays (Mon-Fri): " + weekdays);
            Console.WriteLine("Weekends (Mon-Fri): " + weekends);

            Console.WriteLine("Total days: " + totalDay);


        }
    }
}
