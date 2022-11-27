/* Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.Write("Задайте длину массива: ");
int size = int.Parse(Console.ReadLine()??"");

int[] array = GetArray(size, -1000, 1000);
ShowArray(array);
Console.WriteLine($" -> {SumNumbersOnUnevenPositions(array)}");

int SumNumbersOnUnevenPositions(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ShowArray(int[] arr)
{
    int index = 0;
    Console.Write("[");
    for (; index < arr.Length - 1; index++) Console.Write($"{arr[index]}, ");
    if (index == arr.Length - 1) Console.Write($"{arr[index]}]");
}