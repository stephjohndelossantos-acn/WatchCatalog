namespace Exercise01_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Title: ");

            //inputing
            Console.WriteLine("Enter radius (must be a positive integer): ");
            int radius = int.Parse(Console.ReadLine());

            //int height = GetUserInput("Enter height (must be a positive integer): ");
            Console.WriteLine("Enter height (must be a positive integer): ");
            int height = int.Parse(Console.ReadLine());
            //int radius= GetUserInput("Enter radius (must be a positive integer): ");
            //int height = GetUserInput("Enter height (must be a positive integer): ");

            double surfaceArea = CalculateSurfaceArea(radius, height);
            double volume = CalculateVolume(radius, height);

            DisplayResults(surfaceArea, volume);

        }

        //NOT USED I GIVE UP 
        //getting the input from user
        public static int GetUserInput(string input)
        {
            //condition to keepo going
            while (1 < 5)
            {
                try
                {
                    Console.Write(input);
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong!, Please input a proper");
                }
            }

        }

        public static double CalculateSurfaceArea(double radius, double height)
        {
            return 2 * Math.PI * (height + radius);
        }

        public static double CalculateVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        //dissplayyying
        public static void DisplayResults(double surfaceArea, double volume)
        {
            Console.WriteLine("Surface Area: " + surfaceArea);
            Console.WriteLine("Volume: " + volume);
        }


    }
}
