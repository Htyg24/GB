string num = Console.ReadLine();
bool pol = true;
Console.WriteLine(num);
for (int i = 0; i < num.Length; i++)
{
    if (num[i] != num[num.Length - i - 1]) 
    {
        pol = false;
        break;
    }
}
if (pol)
{
    Console.WriteLine("Число является полиндромом\n");
}
else
{
    Console.WriteLine("Число не является полиндромом\n");
}

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A(3, 6, 8); B(2, 1, -7), -> 15.84

//A(7, -5, 0); B(1, -1, 9)-> 11.53

string[] t = Console.ReadLine().Split(" ");
int[] a = new int[3];
int[] b = new int[3];
int result = 0;
for (int i = 0; i < 3; i++)
{
    a[i] = int.Parse(t[i]);
    b[i] = int.Parse(t[i + 3]);
}
for (int i = 0; i < a.Length; i++)
{
    //a[i] = new Random().Next(0, 50);
    //Console.WriteLine("a " + a[i]);
    //b[i] = new Random().Next(0, 50);
    //Console.WriteLine("b " + b[i]);
    result += (b[i] - a[i]) * (b[i] - a[i]);
}
Console.WriteLine($"{Math.Sqrt(result):f2} \n");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
    Console.WriteLine(Math.Pow(i, 3));