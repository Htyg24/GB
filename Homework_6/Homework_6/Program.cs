//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


string f;
int count = 0;
while (true)
{
    f = Console.ReadLine();
    if (String.IsNullOrEmpty(f))
        break;
    if (int.Parse(f) > 0)
    {
        Console.Clear();
        Console.WriteLine(++count);
    }
}




//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; 5,5)
Console.WriteLine("Ввеите b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввеите k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввеите b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввеите k2");
int k2 = int.Parse(Console.ReadLine());

GetCross(b1, k1, b2, k2);

void GetCross(float b1, float k1, float b2, float k2)
{
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Прямые лежат друг на друге");
    }
    else if (k1 == k2)
        Console.WriteLine("Прямые паралельны");
    else
    {
        float crossX = (b2 - b1) / (k1 - k2);
        float crossY = k1 * crossX + b1;
        Console.WriteLine($"({crossX} {crossY})");
    }
}

