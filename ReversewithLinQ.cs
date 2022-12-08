using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringRM
{
    public class ReversewithLinQ
    {
        public static void ReversebyLinQ()
        {

            Console.WriteLine("This also reverses, but this one by Linq");


            // takes your input
            string input = Console.ReadLine();


            // creates a string <output> , then makes input into a chararray,reverses,and back to array
            string output = new(input.ToCharArray().Reverse().ToArray());


            // types out the reversed output string

            Console.WriteLine(output);


            
        }
    }
}
