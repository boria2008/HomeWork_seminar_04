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
int[] arr = CreateArray(10, 100, 999);

Console.WriteLine($"Array-[{string.Join(",", arr)}]");


int size = arr.Length;
int length = size - 1;

for (int i = 0; i < length / 2; i++, length--)
{
    int temp = arr[i];
    arr[i] = arr[length];
    arr[length] = temp;
}

Console.WriteLine($"Flip Array[{string.Join(",", arr)}]");
// int[] FlipArray(int[] array)
// {
//     int size = array.Length;
//     int length = size - 1;
//     for (int i = 0; i < length / 2; i++, length--)
//     {
//         int temp = array[i];
//         array[i] = array[length];
//         array[length] = temp;
//     }
//     return array;
// }
// int[] flipArray = FlipArray(arr);