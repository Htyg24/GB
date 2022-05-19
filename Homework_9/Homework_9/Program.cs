Print("Задача 64: Задайте значения M и N.\nНапишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до N.");
int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
if (start > end)
{
    int c = start;
    start = end;
    end = c;
}
GetNatural(start, end);

Print("Задача 66: Задайте значения M и N. \nНапишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine(GetSum(start, end));

Print("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. \nДаны два неотрицательных числа m и n.");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
Console.WriteLine(GetAkerman(m, n));


int GetAkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n != 0 && m == 0)
        return GetAkerman(n - 1, 1);
    else
        return GetAkerman(n - 1, GetAkerman(n, m - 1));
}

void GetNatural(int start, int end)
{
    if (start >= end)
        Console.WriteLine(start);
    else
    {
        Console.WriteLine(start);
        GetNatural(++start, end);
    }
}

void Print(string text)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
}

int GetSum(int start, int end)
{
    if (start > end)
        return start;
    return start + GetSum(++start, end);
}