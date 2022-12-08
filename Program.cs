namespace ReverseStringRM
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Reverse string");
            Console.WriteLine("Please input a string to reverse");
            
            Console.WriteLine(ReverseMyString.Inputhandler(Console.ReadLine()));

            ReversewithLinQ.ReversebyLinQ();
        }
    }
}