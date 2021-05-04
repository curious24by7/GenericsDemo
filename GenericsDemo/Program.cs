using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
             
            //ClassBasedGenerics

            PrintArray<int> printArray = new PrintArray<int>(intArray);
            printArray.ToPrint();
            Console.WriteLine("--------------------------------------");
            PrintArray<double> printDouble = new PrintArray<double>(doubleArray);
            printDouble.ToPrint();
            Console.WriteLine("--------------------------------------");
            new PrintArray<int>(intArray).ToPrint(); //easyway
            Console.WriteLine("--------------------------------------");
            new PrintArray<char>(charArray).ToPrint();

            Console.ReadKey();
        }

    }
}
