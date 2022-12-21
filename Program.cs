namespace ReverseStringRM
{
    internal class Program
    {
        static void Main()
        {
            string input;
            do
            {
                Console.WriteLine("Give me a string to reverse!");
                input = Console.ReadLine().ToLower();
                if (input == "")
                {
                    Console.WriteLine("You have to give me some input!");
                }
            }
            while (input == "");
            
            string Reversedstring = string.Empty;
            // 
            for (int i = input.Length - 1; i > -1; i--)
            {
                Reversedstring += input[i];
            }

            // writes out what you put in, before reversal.
            Console.WriteLine($"you typed: " + input);
            Console.WriteLine($"what you typed reversed: " + Reversedstring);
            // returns the string who has been reversed
            
            if (input == Reversedstring)
            {
                Console.WriteLine("This is a Palindrome");
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("This also reverses, but this one by Linq");
            Console.WriteLine($"You typed: {input}");
            // creates a string <output> , then makes input into a chararray,reverses,and back to array
            string output = new(input.ToCharArray().Reverse().ToArray());
            if (input == output)
            {
                Console.WriteLine("This is a Palindrome");
            }
            // types out the reversed output string
            Console.WriteLine($"What you typed but reversed:{output}");
        }
    }
}