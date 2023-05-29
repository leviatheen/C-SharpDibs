using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriengleConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < height; j++) 
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
