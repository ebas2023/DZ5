/*Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3, 4, 1, 77, 65] => 77 - 1 = 76*/

int[] array = GetArray(4, 1, 98);
int c = 0;
Console.WriteLine($"[{String.Join(",", array)}]");
int max=array[0];
int min=array[0];
for (int z = 0; z < 4; z++)
{
    if (array[z] >max)
    {
        max=array[z];
    }
   
     if (array[z] <min)
    {
        min=array[z];
    }
   
 }
c=max-min;
Console.WriteLine($" {max} max");
Console.WriteLine($" {min} min");
Console.WriteLine($" {c} разницу между максимальным и минимальным элементов массива");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

