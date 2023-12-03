// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
Console.Clear();
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int[] FlipArray(int[] array)
{
    for (int i = 0; i <= array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}
int[] arr = CreateArray(10, 100, 999);
Console.WriteLine($"Array-[{string.Join(",", arr)}]");
int[] flipArray = FlipArray(arr);
Console.WriteLine($"FlipArray-[{string.Join(",", flipArray)}]");