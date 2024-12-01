using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightHalfPyramid
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("X ");
                }  
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
