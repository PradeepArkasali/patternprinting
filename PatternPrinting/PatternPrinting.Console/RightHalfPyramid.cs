using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrinting
{
    public static class RightHalfPyramid
    {
        public static void PrintPattern()
        {
            Console.WriteLine("Enter input");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine() ;
            }
            Console.ReadKey();
        }
    }
}
