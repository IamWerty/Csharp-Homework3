using Csharp_Homework3_1;
using System;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

int[] numbers = { 5, 2, 9, 1, 3 };
MyArray arr = new MyArray(numbers);

arr.Show();
arr.Show("Масив створено успішно");
