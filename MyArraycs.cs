using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Homework3_1
{
    public class MyArray : IOutput, IMath, ISort
    {
        private int[] array;

        public MyArray(int[] numbers)
        {
            array = numbers;
        }

        // Методи IOutput
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

        // Методи IMath
        public int Max() => array.Max();

        public int Min() => array.Min();

        public float Avg() => (float)array.Average();

        public bool Search(int value) => array.Contains(value);

        // Методи ISort
        public void SortAsc()
        {
            Array.Sort(array);
        }

        public void SortDesc()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc) SortAsc();
            else SortDesc();
        }
    }
}
