using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Homework3_1
{
    public class MyArray : IOutput
    {
        private int[] array;

        public MyArray(int[] numbers)
        {
            array = numbers;
        }

        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
    }
}
