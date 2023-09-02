// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int CountOfNumbers(string message = " ")
{
    Console.Write($"{message} Введите количество чисел в массиве: ");
    string countNumbers = Console.ReadLine();
    int numbers = int.Parse(countNumbers);
    return numbers;
}
int ArrayMin(string message = " ")
{
    Console.Write($"{message} Введите минимально возможное число в массиве: ");
    string countNumbers = Console.ReadLine();
    int numbers = int.Parse(countNumbers);
    return numbers;
}
int ArrayMax(string message = " ")
{
    Console.Write($"{message} Введите максимально возможное число в массиве: ");
    string countNumbers = Console.ReadLine();
    int numbers = int.Parse(countNumbers);
    return numbers;
}

int[] array = FillArray(CountOfNumbers(), ArrayMin(), ArrayMax());

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
System.Console.WriteLine(string.Join(" ", array));

int SumOddElements(int[] array)
{
    int oddElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            oddElements = array[i] + oddElements;
        }
    }
    return oddElements;
}

System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {SumOddElements(array)}");