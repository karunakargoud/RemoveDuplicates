using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string result = string.Empty;
            for(int i = 0; i < input.Length; i++)
            {
                if(!result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
