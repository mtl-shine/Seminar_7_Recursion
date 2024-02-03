// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System.Xml.Serialization;

int[] CreateRandomArray(int length)
{
    int[] randomArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = rnd.Next(100);
    }
    return randomArray;
}
Console.Write("Please, enter array length: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(length);

int lastIndex = array.Length - 1;
void PrintReversedArray(int[] array, int i)
{
    if (i == 0)
    {
        Console.Write(array[i] + " - reversed array");
        return;
    }
    Console.Write(array[i] + ", ");
    PrintReversedArray(array, i-1);
}

Console.WriteLine($"Origin array: {string.Join(", ", array)}");
PrintReversedArray(array, lastIndex);
