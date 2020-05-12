using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 1;
            for (int i = 7; i>=0; i--)
            {
                for(int j = i; j>=0; j--)
                {
                    Console.Write(' ');
                }
                for(int k = 1; k<=length; k++)
                {
                    Console.Write('*');
                }
                length += 2;
                Console.WriteLine();
            }
        }
    }
}
