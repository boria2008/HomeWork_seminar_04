// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.Clear();
int SumNumber(int number)  // Метод для нахождения суммы цифр целого числа.
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

bool FindSymbol(string str, char simbol) // Метод проверки наличия определенного символа в строке.
{
    foreach (var c in str)
    {
        if (c == simbol)
        {
            return true;
        }
    }
    return false;
}

bool ParityCheckNumber(int number) // Метод для проверки числа на чётность.
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

while (true)
{
    Console.WriteLine("Введите целое число:");
    string stringNumber = Console.ReadLine()!;
    if (int.TryParse(stringNumber, out int result))
    {
        if (ParityCheckNumber(SumNumber(result)))
        {
            Console.WriteLine("Сумма чисел чётная, программа завершена");
            break;
        }
        else Console.WriteLine("Сумма чисел не чётная, программа не завершена");
        continue;
    }
    else if (FindSymbol(stringNumber, 'q'))
    {
        Console.WriteLine("Некорректный ввод, но присутствует STOP-символ 'q', программа завершена");
        break;
    }
    else Console.WriteLine("Некорректный ввод, программа не завершена");
}