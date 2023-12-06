заметки по си шарп:
<!-- Установить курсор -->
Console.SetCursorPosition(rows,columns);
<!-- Заполнение пустая строка -->
string digits=String.Empty;

digits=(number%10).ToString + "\t" +digits 
Console.WriteLine($"[{string.Join("\t", array)}]");
 <!-- Возведение в степень i в степени j; -->
Math.Pow(i,j)-
<!-- // Округление  Math.Round(вещественное число, количество цифр после запятой) -->
array[i] = Math.Round(new Random().NextDouble() * new Random().Next(1, 100), 3);
<!-- .ToLower()  .ToUpper() приводят строку к нижнему и верхнему регистру. -->
char symbol = 'a';
Console.WriteLine(char.ToUpper(symbol));

char secondSymbol = 'B';
Console.WriteLine(char.ToLower(secondSymbol));

<!-- Проверка регистра -->
char symbol = 'ф';
// Console.WriteLine(char.ToUpper(symbol));
if (char.IsUpper(symbol))
{
    Console.WriteLine("Символ в верхнем регистре");
}
else
{
    Console.WriteLine("Символ в нижнем регистре");
}
<!-- Проверка на наличие других символов кроме цифр, 
принимает строку и если в строке все цифры возвращает целое число-->
 int.TryParse(number, out int result);
    return result;
<!-- Считать число из строки, два варианта, первый работает быстрее и занимает меньше места в памяти,
второй больше преднозначен для другого =, а именно переводить данные из одного тип в другой-->
    Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!), result = 0; // ["345"] <- 345
int n = Convert.ToInt32(Console.ReadLine()); // ["123"] -> 123 -> [123]