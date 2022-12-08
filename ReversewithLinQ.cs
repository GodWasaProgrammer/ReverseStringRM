namespace ReverseStringRM
{
    public class ReversewithLinQ
    {
        public static void ReversebyLinQ()
        {

            Console.WriteLine("This also reverses, but this one by Linq");


            // takes your input
            string input = Console.ReadLine();
            Console.WriteLine($"You typed: {input}");


            // creates a string <output> , then makes input into a chararray,reverses,and back to array
            string output = new(input.ToCharArray().Reverse().ToArray());

            if (input == output && input != "")

            {
                Console.WriteLine("This is a Palondrime");
            }

            // types out the reversed output string

            Console.WriteLine(output);



        }
    }
}
