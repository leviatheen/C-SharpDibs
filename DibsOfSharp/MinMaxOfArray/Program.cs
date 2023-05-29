using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 88, 81, 1930, 192, 5, 12, 231, 233, 112, 5495, 30, 101 };
            int minValue = myArray[0];
            int maxValue = myArray[0];
            //min
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue) 
                {
                    minValue = myArray[i];
                }
            }
            //max
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }
            }
            Console.WriteLine(minValue);
            Console.WriteLine(maxValue);

            Console.ReadLine();
        }
    }
}
