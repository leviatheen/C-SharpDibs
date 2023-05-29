using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEnterKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCount];
            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.Write($"\nВведите элимент массива под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nВывод массива: ");
            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.Write(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}
