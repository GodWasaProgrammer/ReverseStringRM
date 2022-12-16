namespace ReverseStringRM
{
    public static class ReverseMyString
    {
        
        public static void Inputhandler()
        {
            
            string input;
            

            do
            {
                Console.WriteLine("Give me a string to reverse!");
                input = Console.ReadLine();
                

                if (input == "")
                {
                    Console.WriteLine("You have to give me some input!");
                }
            }
            while (input == "");
            

            char[] CharArray = input.ToCharArray(); // makes a char array out of our string 
            // declare an empty string to fill reversely
            string Reversedstring = string.Empty;

            // 
            for (int i = CharArray.Length - 1; i > -1; i--)
            {
                Reversedstring += CharArray[i];
            }

            string inputtolower = input.ToLower();
            input = inputtolower;

            string Reversedstringtolower = Reversedstring.ToLower();
            Reversedstring = Reversedstringtolower;
            // writes out what you put in, before reversal.
            Console.WriteLine($"you typed: " + input);
            // returns the string who has been reversed
            // if input is the same as reversed string and input is not equal to ""
            if (input == Reversedstring)
            {
                Console.WriteLine("This is a Palindrome");
            }
            
        }
    }
}
