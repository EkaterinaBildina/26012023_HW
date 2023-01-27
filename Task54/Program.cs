// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
/* 1 4 7 2
   5 9 2 3
   8 4 2 4
В итоге получается вот такой массив:
   7 4 2 1
   9 5 3 2
   8 4 4 2
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

int[,] RowsSortArray(int[,] matrix1)
{
    int[,] rowSort = new int[matrix1.GetLength(0),matrix1.GetLength(1)];


    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1)-1; j++)
        {
            if (matrix1[i, j] > matrix1[i, j + 1])
            {
                int tempMax;
                tempMax = matrix1[i, j];
                matrix1[i, j] = matrix1[i, j + 1];
                matrix1[i, j + 1] = tempMax;
            }
        }
    }
    return rowSort;
}






void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);

Console.WriteLine("Sring.Empty");

int[,] rowSort = RowsSortArray(matrix);
PrintMatrix(rowSort);

