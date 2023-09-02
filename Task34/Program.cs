// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int CountOfNumbers(string message = " ")
{
    Console.Write($"{message} Введите, сколько трехзначных чисел в массиве: ");
    string countNumbers = Console.ReadLine();
    int numbers = int.Parse(countNumbers);
    return numbers;
}

int[] array = FillArray(CountOfNumbers(), 100, 999);

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

int CountEvenNumbers(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}

System.Console.WriteLine($"Количество четных чисел: {CountEvenNumbers(array)}");

