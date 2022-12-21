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

            string reversedString = string.Empty;
            for (int i = input.Length - 1; i > -1; i--)
            {
                reversedString += input[i];
            }

            // writes out what you put in, before reversal.
            Console.WriteLine($"you typed: " + input);
            Console.WriteLine($"what you typed reversed: " + reversedString);
            if (input == reversedString)
            {
                Console.WriteLine("This is a Palindrome");
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("This also reverses, but this one by Linq");
            Console.WriteLine($"You typed: {input}");
            
            // types out the reversed output string
            Console.WriteLine($"What you typed but reversed:{reversedString}");
            // sets reversedstring , input to character array, reverses it, back to array
            reversedString = new(input.ToCharArray().Reverse().ToArray());
            if (input == reversedString)
            {
                Console.WriteLine("This is a Palindrome");
            }

        }
    }
}