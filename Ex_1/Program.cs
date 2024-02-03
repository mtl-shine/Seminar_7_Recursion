// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Please, enter the number from which you want to start counting. M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the number you want to count down to. N = ");
int N = Convert.ToInt32(Console.ReadLine());

ShowNumbers(M,N);

void ShowNumbers(int M, int N)
{
    if (M > N)
    {
        Console.Write("Conditions are not met. N must be greater than or equal to M");
        return;
    }
    if (M == N)
    {
        Console.Write(N);
        return;
    }
    Console.Write(M + ", ");
    ShowNumbers(M + 1, N);
}
