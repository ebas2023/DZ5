/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int[] array = GetArray(4, 100, 998);
int c = 0;
Console.WriteLine($"[{String.Join(",", array)}]");

for (int z = 0; z < 4; z++)
{
    if (array[z] % 2 == 0)
    {
        c++;
    }
}

Console.WriteLine($" {c} из них чётные");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

