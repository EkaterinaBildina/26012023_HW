// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов. 

// Например, задан массив:

/*
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] MinSumRow(int[,] array2D)
{
    int[,] sumArray2D = new int[array2D.GetLength(0), 1];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            rowSum += array2D[i, j];
            sumArray2D[i, 0] = rowSum;
        }
    }
    return sumArray2D;
}

void FindMinSum(int[,] array)
{
    int minRowIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[minRowIndex, 0] >= array[i, 0]) minRowIndex = i;
    }
    Console.WriteLine($"Row's number with min sum of elements is {minRowIndex + 1}");
}

int[,] matrix = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(matrix);
Console.WriteLine("Row's Sum:");

int[,] sumRow = MinSumRow(matrix);
PrintMatrix(sumRow);

FindMinSum(sumRow);
