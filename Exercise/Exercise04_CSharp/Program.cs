namespace Exercise04_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display
            Console.WriteLine("                 Exercise 4!");
            Console.WriteLine("                 Prime Number Identification Program");
            Console.WriteLine("This program calculates the prime number of the number range given.");
            int start = 0;
            int end = 0;
            bool valid = false;
            
            //will check until input is valid
            while (!valid) 
            { 
                try
                {
                    //start
                    Console.Write("Enter the start of the range: ");
                    start = int.Parse(Console.ReadLine());

                    

                    //end
                    Console.Write("Enter the end of the range: ");
                    end = int.Parse(Console.ReadLine());

                    //if start is bigger number than end, we must also start with 0 since we can count from 0 then 1
                    if(start >= end)
                    {
                        Console.WriteLine("Error, enter a start value that is less than or equal to end value. ");
                    }
                    else
                    {
                        valid = true;
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine("Error: Please enter valid intgesers only.");
                }
            }

            //my list for the all gvinen user input on the prime numbers ranges
            List<int> primeNumbers = new List<int>();

            //1-10     ; 10-20
            //will now check the numbers 1 by one, start to end
            for(int i = start; i <= end; i++)
            {
                //calling IsPrime
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }
            //display results 
            if(primeNumbers.Count == 0)
            {
                Console.WriteLine("\nNo prime numbers found ");
            }
            else
            {
                //sort then reverse since we must arrange first then print bakcwards
                primeNumbers.Sort();
                primeNumbers.Reverse();

                Console.WriteLine("Prime numbers in descending order: ");

                //print forEach
                foreach(int print in primeNumbers)
                {
                    Console.WriteLine(print);
                }
            }

        }//main
        static bool IsPrime(int number)
        {
            if(number <= 1)
            {
                return false;
            }

            //check number if divislbe by 2, if yes, not prime
            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


    }




}
