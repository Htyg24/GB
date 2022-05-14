//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] Array = GetArr();
Console.WriteLine(String.Join(", ", Array));
Console.WriteLine(Array.Where(i => i % 2 == 0).Count());


//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

int[] Array2 = GetArr();
GetSumOddIndexes(Array2);


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] Array3 = new double[int.Parse(Console.ReadLine())].Select(i => i = new Random().Next(-1000, 1001)).ToArray();
Console.WriteLine(String.Join(", ", Array3));
Console.WriteLine(Array3.Max() - Array3.Min());



int[] GetArr(int size = 20, int min = -100, int max = 101)
{
    int[] Array2 = new int[size].Select(i => i = new Random().Next(min, max)).ToArray();
    return Array2;
}

void GetSumOddIndexes(int[] Array2)
{
    int sum = 0;
    for (int i = 1; i < Array2.Length; i += 2)
    {
        sum += Array2[i];
    }
    Console.WriteLine(sum);
}