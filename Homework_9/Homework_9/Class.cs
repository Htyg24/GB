using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassInteraction
{
    public static class MyExample
    {
        public static int[] GetOneTwoDimentionArray(int length, int min = 0, int max = 100)
        {
            Random random = new Random();
            int[] array = new int[length].Select(x => x = random.Next(min, max + 1)).ToArray();
            return array;
        }

        public static void PritOneDimentionArray(int Array)
        {
            Console.WriteLine(String.Join(' ', Array));
        }

        public static int[,] GetIntTwoDimentionArray(int raws = 5, int columns = 5, int min = 0, int max = 100)
        {
            Random random = new Random();
            int[,] Array = new int[raws, columns];
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns; j++)
                    Array[i, j] = random.Next(min, max); ;
            }
            return Array;
        }
        public static double[,] GetDoubleTwoDimentionArray(int raws = 5, int columns = 5, int min = 0, int max = 100, string type = "int")
        {
            Random random = new Random();
            double[,] Array = new double[raws, columns];
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns; j++)
                    Array[i, j] = random.Next(min, max); ;
            }
            return Array;
        }


        public static void PrintIntTwoDimentionArray(int[,] Array, int lengthOfArrayElement = 5)
        {
            int startDistanceFromTop = Console.CursorTop;
            for (int i = 0; i <= Array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * lengthOfArrayElement, i + startDistanceFromTop);
                    Console.Write(Array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        public static int[] SortArray(int[] Array, int startSort, int endSort)
        {
            int referencePoint = new Random().Next(startSort, endSort);
            int slide = endSort;
            int c = Array[startSort];
            Array[startSort] = Array[referencePoint];
            Array[referencePoint] = c;
            referencePoint = startSort;
            while (referencePoint < slide)
            {
                if (Array[referencePoint + 1] > Array[referencePoint])
                {
                    c = Array[slide];
                    Array[slide] = Array[referencePoint + 1];
                    Array[referencePoint + 1] = c;
                    slide--;
                }
                else
                {
                    c = Array[referencePoint + 1];
                    Array[referencePoint + 1] = Array[referencePoint];
                    Array[referencePoint] = c;
                    referencePoint++;
                }
            }
            if (startSort < referencePoint)
                Array = SortArray(Array, startSort, referencePoint - 1);
            if (endSort > referencePoint + 1)
                Array = SortArray(Array, referencePoint + 1, endSort);
            return Array;
        }
    }
}

