// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
Console.Clear();
Random random = new Random();
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}
int CountEvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int[] arr = CreateArray(10, 100, 999);
Console.WriteLine($"[{string.Join(",", arr)}]");
Console.WriteLine($"Количество элемнов массива={arr.Length}");
Console.WriteLine($"Количество четных элементов массива={CountEvenNumber(arr)}");