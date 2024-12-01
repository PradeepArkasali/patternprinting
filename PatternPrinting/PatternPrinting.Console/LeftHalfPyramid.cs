using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrinting
{
    public static class LeftHalfPyramid
    {
        public static void PrintPattern()
        {
            Console.WriteLine("Enter input");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < (2*(rows-i)-1); j++)
                {
                    Console.Write(" ");
                }

                for(int k = 0; k <= i; k++)
                {
                    Console.Write("X ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
