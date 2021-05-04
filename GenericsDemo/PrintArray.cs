using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{     
    class PrintArray<T>
    {   //ClassBasedGenerics
        private T[] InputArray;
        public PrintArray(T[] inputArray)
        {
            this.InputArray = inputArray;
        }
        public void ToPrint()
        {
            foreach (var element in InputArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}


