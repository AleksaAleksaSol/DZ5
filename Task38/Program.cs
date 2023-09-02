// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

System.Console.Clear();
int CountOfElements(string message = "")
{
    Console.Write($"{message}Введите количество элементов в массиве: ");
    int elementsCount = int.Parse(Console.ReadLine());
    return elementsCount;
}
double[] array = new double[CountOfElements()];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t ");
    array[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("\nСоздан массив:");
Console.WriteLine();
Console.WriteLine(string.Join("\t", array));
Console.WriteLine();

double max = array.Max();
Console.WriteLine($"Максимальное число массива: {max}");

double min = array.Min();
Console.WriteLine($"Минимальное число массива: {min}");

double result = Math.Round(max - min,2);
Console.WriteLine($"Разница между максимальным и минимальным числом:  {result}");