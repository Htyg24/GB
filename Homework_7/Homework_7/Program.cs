using MassInteraction;
//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Enter the number of lines");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
int n = int.Parse(Console.ReadLine());
double[,] Array = new double[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Array[i, j] = Convert.ToDouble(random.Next(100, 1000)) / 10;
    }
}


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(Array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Press any key");
Console.ReadKey();



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17->такого числа в массиве нет



Console.Clear();
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве\n" +
    "и возвращает значение этого элемента или же указание, что такого элемента нет.");

Console.WriteLine("\nEnter number of element\n");
int num = int.Parse(Console.ReadLine());
int[,] IntArray = MyExample.GetIntTwoDimentionArray(5, 11);
MyExample.PrintIntTwoDimentionArray(IntArray, 3, 8);
if (num < IntArray.GetLength(0) * IntArray.GetLength(1))
    Console.WriteLine(IntArray[num / IntArray.GetLength(1), num % IntArray.GetLength(1)]);
else 
    Console.WriteLine("Такого числа в массиве нет");

Console.WriteLine();


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double avarage = 0;
for (int i = 0; i < IntArray.GetLength(1); i++)
{
    for (int j = 0; j < IntArray.GetLength(0); j++)
    {
        avarage += IntArray[j, i];        
    }
    Console.WriteLine($"Avarage of {i} colomn {avarage / Convert.ToDouble(IntArray.GetLength(0)):f2}; ");
}
Console.ReadKey( );