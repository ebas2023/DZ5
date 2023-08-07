/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] array = GetArray(4, -98, 98);
int c = 0;
Console.WriteLine($"[{String.Join(",", array)}]");

for (int z = 0; z < 4; z++)
{
    if (z % 2 != 0)
    {
        c=c+array[z];
    }
}

Console.WriteLine($" {c} сумму элементов, стоящих на нечётных индексах");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

