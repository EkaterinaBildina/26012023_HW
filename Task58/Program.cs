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


    if (matrixA.GetLength(1) == matrixB.GetLength(0)) // Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором; в этом случае говорят, что форма матрицсогласована.
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {

                for (int n = 0; n < matrixA.GetLength(1); n++)
                {
                    multiMatrix[i, j] += matrixA[i, n] * matrixB[n, j];
                }
            }
        }
    }
    else Console.WriteLine("Impossible to multiply because of error Matrix's size");
    return multiMatrix;
}

int[,] matrix1 = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(4, 2, 1, 5);
PrintMatrix(matrix2);

Console.WriteLine();
int[,] multiMatrix = MultiplyTwoMatrix(matrix1, matrix2);
PrintMatrix(multiMatrix);