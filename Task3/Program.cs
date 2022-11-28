/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
Console.Write("Задайте длину массива: ");
int size = int.Parse(Console.ReadLine()??"");

double[] array = GetArray(size);
ShowArray(array);
Console.WriteLine($" -> {MaxValue(array) - MinValue(array)}");



double MinValue(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    return min;
}

double MaxValue(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    return max;
}

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < res.Length; i++)
        res[i] = Math.Round(new Random().NextDouble() * 100, 2);
    return res;
}

void ShowArray(double[] arr)
{
    int index = 0;
    Console.Write("[");
    for (; index < arr.Length - 1; index++)
        Console.Write($"{arr[index]},   ");
    if (index == arr.Length - 1)
        Console.Write($"{arr[index]}]");
}