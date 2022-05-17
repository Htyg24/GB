using MassInteraction;
PrintTaskCondition("\nЗадача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n");
int rows = 8;// int.Parse(Console.ReadLine());
int columns = 8;//int.Parse(Console.ReadLine());
int[,] Array = MyExample.GetIntTwoDimentionArray(rows, columns);

MyExample.PrintIntTwoDimentionArray(Array);
for (int i = 0; i < Array.GetLength(0); i++)
{
    int[] SupportArray = new int[Array.GetLength(1)];

    for(int j = 0; j < SupportArray.Length; j++)
        SupportArray[j] = Array[i, j];

    MyExample.SortArray(SupportArray, 0, SupportArray.Length - 1);

    for (int j = 0; j < SupportArray.Length; j++)
        Array[i, j] = SupportArray[j];
}
Console.WriteLine("");
MyExample.PrintIntTwoDimentionArray(Array, 4);
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int k = 0; k < Array.GetLength(1) - 1; k++)
    {
        if (Array[i, k] > Array[i, k + 1])
        {
            Console.WriteLine("Alarm");
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}

PrintTaskCondition("\nЗадача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.\n");

int fewsum = 0;
int index = 0;
for (int i = 0; i < Array.GetLength(0); i++)
{
    int sum = 0; 
    for ( int j = 0; j < Array.GetLength(1); j++)
    {
        sum = sum + Array[i, j];
    }
    if (i == 0)
        fewsum = sum;
    else
    {
        if (sum < fewsum)
        {
            fewsum = sum;
            index = i;
        }
    }            
}
Console.WriteLine($"{index} строка с насменьшей суммой");

PrintTaskCondition("\nЗадача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n");

Console.WriteLine("\nEnter size of arrays");
rows = 8;// int.Parse(Console.ReadLine());
columns = 8;// int.Parse(Console.ReadLine());
int[,] ArrayMulti1 = MyExample.GetIntTwoDimentionArray(rows, columns);
int[,] ArrayMulti2 = MyExample.GetIntTwoDimentionArray(rows, columns);
int[,] ArrayMulti3= new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        ArrayMulti3[i, j] = ArrayMulti1[i, j] * ArrayMulti2[i, j];
    }
}
Console.WriteLine("First array");
MyExample.PrintIntTwoDimentionArray(ArrayMulti1, 6);
Console.WriteLine("Second array");
MyExample.PrintIntTwoDimentionArray(ArrayMulti2, 6);
Console.WriteLine("Multiplication of arrays");
MyExample.PrintIntTwoDimentionArray(ArrayMulti3, 6);
Console.WriteLine();

PrintTaskCondition("\nЗадача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел." +
    "\n Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.\n");

int height = 3;
int width = 3;
int depth = 3;
int[,,] threeDementionArray = new int[height, width, depth];
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        for (int k = 0; k < depth; k++)
        {
            threeDementionArray[i, j, k] = i * width * height + j * height + k;
            Console.Write($"{threeDementionArray[i, j, k]} ({i}, {j}, {k})");
        }
        Console.WriteLine();
    }
}

PrintTaskCondition("\nЗадача 62. Заполните спирально массив 4 на 4. \"Работает с любым размером\"\n");

rows = int.Parse(Console.ReadLine());
columns = int.Parse(Console.ReadLine());
int[,] SnailArray = new int[rows, columns];
MyExample.PrintIntTwoDimentionArray(FeelRight(SnailArray));

int[,] FeelRight(int[,] Array, int step = 1, int i = 0, int j = 0)
{
    while (j + 1 < columns && Array[i, j + 1] == 0)
    {
        Array[i, j] = step++;
        j++;
    }
    if (i + 1 < rows && Array[i + 1, j] == 0)
        Array = FeelDown(Array, step, i, j);
    if (step == Array.Length)
        Array[i, j] = step;
        return Array;
}

int[,] FeelDown(int[,] Array, int step = 1, int i = 0, int j = 0)
{
    while (i + 1 < rows && Array[i + 1, j] == 0)
    {
        Array[i, j] = step++;
        i++;
    }
    if (j - 1 >= 0 && Array[i, j - 1] == 0)
    Array = FeelLeft(Array, step, i, j);
    if (step == Array.Length)
        Array[i, j] = step;
    return Array;
}

int[,] FeelLeft(int[,] Array, int step = 1, int i = 0, int j = 0)
{
    while (j - 1 >= 0 && Array[i, j - 1] == 0)
    {
        Array[i, j] = step++;
        j--;
    }
    if (Array [i - 1, j] == 0)
        Array = FeelUp(Array, step, i, j);
    if (step == Array.Length)
        Array[i, j] = step;
    return Array;
}

int[,] FeelUp(int[,] Array, int step = 1, int i = 0, int j = 0)
{
    while (i - 1 >= 0 && Array[i - 1, j] == 0)
    {
        Array[i, j] = step++;
        i--;
    }
    if (Array[i, j + 1] == 0)
        Array = FeelRight(Array, step, i, j);
    if (step == Array.Length)
        Array[i, j] = step;
    return Array;
}

void PrintTaskCondition(string task)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(task);
    Console.ResetColor();
}