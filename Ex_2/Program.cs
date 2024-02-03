// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int CalculateAckermannFunction(int m, int n)
{
    if (m == 0 && n >= 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return CalculateAckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
    }
    else // (m < 0 | n < 0)
    {
        Console.WriteLine("Conditions are not met"); // проверка на отрицательность
        return 0;
    }
}

Console.Write("Please, enter first argument. m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter second argument. n = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalculateAckermannFunction(m,n));
