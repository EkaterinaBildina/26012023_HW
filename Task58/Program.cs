// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
/*
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MultiplyTwoMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] multiMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
  
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < multiMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiMatrix.GetLength(1); j++)
            {
                multiMatrix[i, j] = matrixA[i, j] * matrixB[i, j] + matrixA[i, j+1] * matrixB[i+1, j];
            }
        }
    }
    else Console.WriteLine("Impossible to multiply because of error Matrix's size");
    return multiMatrix;
}

int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(2, 1, 1, 5);
PrintMatrix(matrix2);

Console.WriteLine();
int[,] multiMatrix = MultiplyTwoMatrix(matrix1, matrix2);
PrintMatrix(multiMatrix);