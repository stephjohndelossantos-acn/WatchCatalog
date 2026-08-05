using System;
namespace Exercise06_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool valid = false;            

            Console.WriteLine("                 Smallest Missing Positive Integer Finder");
            Console.WriteLine("This program returns the smallest positive integer in a set of number or array of numbers.");
            
            //similar with my exercise 04 userInput will check unitl false
            
            try
            {
                //user input
                Console.Write("Enter a list of numbers separated by spaces: ");

                //storing it in string first
                string input = Console.ReadLine();

                //removing the commas
                input = input.Replace(",", "");
                //removing teh spaces
                string[] values = input.Split(' ');

                //the szie of array will be the length of the values
                //declare
                int[] numbers = new int[values.Length];

                //parsing
                for(int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = int.Parse(values[i]);  
                }

                //printing
                Console.Write("Given numbers: [");
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.Write("]");

                //calling method
                int result = FindSmallestNumber(numbers);
                
                //smallest that is missing from array
                Console.WriteLine("\nSmallest Positive Integer is: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e + "  Please enter numbers only: ");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e + " Please input numbers in range of -1,000,000 or 1,000,000 only");
            }
            
        }        //main end
        public static int FindSmallestNumber(int[] numbers)
        {
           int smallest = 1;

            Array.Sort(numbers);

            //checking if the element in array is equal to smallest then we iterate until it doesnt match any element
            foreach (int num in numbers)
            {
                if(num == smallest)
                {
                    smallest++;
                }
            }
            return smallest;
        }
    }
        
}


