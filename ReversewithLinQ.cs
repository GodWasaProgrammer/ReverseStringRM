namespace ReverseStringRM
{
    public class ReversewithLinQ
    {
        public static void ReversebyLinQ()
        {
            Console.WriteLine("This also reverses, but this one by Linq");
            // takes your input
            string input;
            do
            {
                Console.WriteLine("input your string to reverse by LinQ!");
                input = Console.ReadLine();
                input= input.ToLower();
                if (input == "")
                {
                    Console.WriteLine("Give me input! you shall not pass otherwise!");
                }

            } while (input == "");

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
