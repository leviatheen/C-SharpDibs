using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine(":\t:\t:");
            for (int i = 0; i < height; i++) 
            {
                for (int j = 0; j <= i; j++) 
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
