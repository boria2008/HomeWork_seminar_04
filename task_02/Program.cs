// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
Console.Clear();
// Random random = new Random().Next(100, 1000);
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
    // Console.WriteLine($"{string.Join(",",array)}");
}
int[] arr = CreateArray(10, 100, 999);
Console.WriteLine($"[{string.Join(",", arr)}]");
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных элементов массива={count}");