while (true)
{
    Console.WriteLine("Введите число от 1 до 4");
    int c = Convert.ToInt32(Console.ReadLine());
    switch (c)
    {
        case 0:
            MaxOfTwo();     // Большее из двух
            break;
        case 1:
            MaxOfThree();   //Большее из трех
            break;
        case 2:
            EvenNumber();   //Четное/ нечетное
            break;
        case 3:
            AllTwo();       //Все двойки от одного до числа
            break;
        default:
            Console.WriteLine("Попробуйте еще раз");
            break;
    }
}

void MaxOfTwo()
{
    Console.Clear();
    Console.WriteLine("0\nВведите число");
    Console.WriteLine("Введите первое число");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int j = int.Parse(Console.ReadLine());
    if (i > j) j = i;
    Console.WriteLine($"max = {j}");
}

void MaxOfThree()
{
    Console.Clear();
    Console.WriteLine("1\nВведите число");
    Console.WriteLine("Введите первое число");
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int j = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int k = int.Parse(Console.ReadLine());
    if (i < j) i = j;
    if (i < k) i = k;
    Console.WriteLine($"max = {i}");
}

void EvenNumber()
{
    Console.Clear();
    Console.WriteLine("2\nВведите число");
    if (Convert.ToBoolean(int.Parse(Console.ReadLine()) % 2))
    {
        Console.WriteLine("Число не является четным");
    }
    else
    {
        Console.WriteLine("Чисило является четным");
    }
}

void AllTwo()
{
    Console.Clear();
    Console.WriteLine("3\nВведите число");
    int i = int.Parse(Console.ReadLine());
    int k;
    if (i > 0)
    {
        k = 2;
        while (k < i)
        {
            Console.WriteLine(k);
            k += 2;
        } 
    }
    else
    {
        k = 0;
        while (k > i)
        {
            Console.WriteLine(k);
            k -= 2;
        }
    }
}
//