//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("Введите А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите В");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(GetPow(a, b) + "\n");




//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Ввдите число ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {num} ровна {GetSumOfNum(num)}\n");




//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Вывод элементов массива");
GetArr();





void GetArr()
{
    Random r = new Random();
    int[] Arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        Arr[i] = r.Next();
    }
    Console.WriteLine(String.Join(", ", Arr));
}


int GetSumOfNum(int num)
{
    int c = 0;
    if (num / 10 != 0)
        c += GetSumOfNum(num / 10);
    c += num % 10;
    return c;
}


int GetPow(int a, int b)
{
    if (b > 1)
        a *= GetPow(a, b - 1);
    return a;
}