// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных чисел в промежутке от M до N.

int SumInRow(int m, int n)
{
    if (m == n) return m;
    else return n + SumInRow(m, n - 1); 
}

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumInRow(number1, number2));