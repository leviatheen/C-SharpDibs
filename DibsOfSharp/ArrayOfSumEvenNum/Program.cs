using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfSumEvenNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 44, 3, 4, 5, 57, 6, 7, 8, 123, 9, 10, 11, 123345, 12, 1111, 13, 128 };

            int result = 0;

            for (int i = 0; i < myArray.Length; i++) 
            {
                if (myArray[i] % 2 == 0) 
                {
                    result += myArray[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
