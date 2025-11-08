using Csharp_Homework3_1;
using System;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;


int[] numbers = { 5, 2, 9, 1, 3 };
MyArray arr = new MyArray(numbers);

arr.Show("Поточний масив:");

Console.WriteLine($"Максимум: {arr.Max()}");
Console.WriteLine($"Мінімум: {arr.Min()}");
Console.WriteLine($"Середнє арифметичне: {arr.Avg():F2}");

Console.WriteLine($"Пошук числа 9: {arr.Search(9)}");
Console.WriteLine($"Пошук числа 100: {arr.Search(100)}");

arr.SortAsc();
arr.Show("Після сортування за зростанням:");

arr.SortDesc();
arr.Show("Після сортування за спаданням:");

arr.SortByParam(true);
arr.Show("SortByParam(true):");

arr.SortByParam(false);
arr.Show("SortByParam(false):");

