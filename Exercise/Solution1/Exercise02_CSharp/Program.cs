namespace Exercise02_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //height our int field
            int triangleHeight = 0;

            //description of our program
            Console.WriteLine("                 Exercise 2!");
            Console.WriteLine("                 Triangle Exercise");
            Console.WriteLine("This program calculates the area of a triangle.");

            //asking the usre all over again till we get a proper vaild input
            while (true)
            {
                try //try &try until we succeed
                {
                    Console.Write("Please enter the height of the triangle (1-20): ");
                    triangleHeight = Convert.ToInt32(Console.ReadLine());
                    if (triangleHeight < 1 || triangleHeight > 20)
                    {
                        Console.WriteLine("Height must be between 1 and 20. Again my friend");
                        continue;
                    }
                    //if we get here, we have a valid input, so we can break out of the loop
                    break; //go out of the while loop
                    
                    Console.WriteLine("Enter triangle height (1-20");                    
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " Invalid input my friend. Please enter a number between 1 and 20.");
                }
            }

        DisplayTriangle(triangleHeight);
        //main method ends here

        Console.WriteLine("Program done");
        string input = Console.ReadLine();
        }

        //displaying the triangle method
        public static void DisplayTriangle(int height)
        {
            //this will slowly consume the blank spaces
            for (int row = height; row >= 1; row--)
            {
                //for Printing the spaces need blank
                for (int space = 0; space <= height; space++)
                {
                    //THe blanks
                    Console.Write(" ");
                }
                //Pritning Stars
                for (int star = 1; star <= row; star++)
                {
                    Console.Write("*");
                }
                //for the new line each stars
                Console.WriteLine();
            }
        }


    }
}
