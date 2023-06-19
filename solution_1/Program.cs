// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string NumbersRow(int n)
{
    if (n == 1) return $"1";
    else return $"{n} {NumbersRow(n - 1)}";
} 

int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(NumbersRow(num));