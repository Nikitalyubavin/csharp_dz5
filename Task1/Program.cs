/* Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();
Console.Write("Задайте длину массива: ");
int size = int.Parse(Console.ReadLine()??"");

int[] array = GetArray(size, 100, 1000);
ShowArray(array);
Console.WriteLine($" -> {ShowEvenNumbered(array)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ShowEvenNumbered(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

void ShowArray(int[] arr)
{
    int index = 0;
    Console.Write("[");
    for (; index < arr.Length - 1; index++) Console.Write($"{arr[index]}, ");
    if (index == arr.Length - 1) Console.Write($"{arr[index]}]");
}