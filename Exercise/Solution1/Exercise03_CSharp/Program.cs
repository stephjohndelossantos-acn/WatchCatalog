namespace Exercise03_CSharp
{
    internal class Program
    {
        //making it visbile so we can use it on other classes outside of main
        static int vowels = 0;
        static int consonants = 0;
        static void Main(string[] args)
        {
            
            Console.WriteLine("============================================================");
            Console.WriteLine("                 String Analysis Program");
            Console.WriteLine("============================================================");
            Console.WriteLine("A .NET Practice exam. This program counts the number");

            //calling UserInput method and passing theresult to local sentence
            string sentence = UserInput();

            //magic method
            StringProcessing(sentence);

            //auto display since static
            OutputDisplay();

        }
        //method for input gathering/ or taking the sentence
        public static string UserInput()
        {
            
            //where we store the user input
            //blank it first para since we can put something inside anyways
            string sentence = "";
            //we use doWhile loop since I need it to do and check first then check the condition later
            do
            {
                try
                {
                    Console.Write("Enter a sentence: ");
                    sentence = Console.ReadLine();
                    //checking if blank
                    if (sentence == "")
                    {
                        Console.WriteLine("Input is empty: Put a proper sentence");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message + "Invalid");
                }

            //as long as true
            } while(sentence == "");

        return sentence;
            
        }
        //QWERTqwertyu /all char
        //qweqweqweqweqwe       // making it ssmall
        //aeiou             //vowels
        //countit

        public static void StringProcessing(string sentence)
        {
            //foreach for counting I use charac since char is naka reserva keyword
            foreach(char charac in sentence)
            {
                //checking equivalent to a letter
                if(char.IsLetter(charac))
                {
                    //making the letter all small so no case snesitive
                    char c = char.ToLower(charac);

                    //similar to SQL COntains command    //we count here
                    if("aeiou".Contains(c))
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }
            
            ////

        }
        //Displaying method, invoked in Main
        public static void OutputDisplay()
        {
            Console.WriteLine("Results: ");
            Console.WriteLine("Vowels: " + vowels);
            Console.WriteLine("Consonants: " + consonants);
        }

        ///
    }

    //

}