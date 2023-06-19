//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckerMann(int m, int n)
{
    if (m == 0) return n + 1;
    else 
        if (m > 0 && n == 0) return AckerMann(m - 1, 1);
        else return  AckerMann(m - 1, AckerMann(m, n - 1));
}

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AckerMann(number1, number2));