using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringRM
{
    public class ReverseMyString
    {
        public static string Inputhandler(string input)
        {
            char[] CharArray = input.ToCharArray(); // makes a char array out of our string

            // declare an empty string to fill reversely

            string Reversedstring = string.Empty;

            // 

            for (int i = CharArray.Length - 1; i > -1; i--)

            {
                Reversedstring += CharArray[i];
            }

            
            Console.WriteLine(input);
            
            return Reversedstring;
        }

        

    }
    
}
