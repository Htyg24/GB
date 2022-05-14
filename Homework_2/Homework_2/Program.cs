int c = int.Parse(Console.ReadLine());
switch (c)
{
    case 0:
        GetSecondNum();
        break;
    case 1: 
        GetThirdNum();
        break;
    case 2:
        Weekend();
        break;
    default:
        Console.WriteLine("Попробуй еще раз");
        break;
}

void GetSecondNum()
{
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine(num / 10 % 10);
}

void GetThirdNum()
{
    string num = Convert.ToString(new Random().Next());
    Console.WriteLine(num);
    if (num.Length >= 3)
        Console.WriteLine(num[2]);
    else
        Console.WriteLine("Третьей цифры нет");
}


void Weekend()
{
    int num = new Random().Next(1, 8);
    string day = (num < 6) ?"День не является выходным":"День является выходным";
    Console.WriteLine(day);
}