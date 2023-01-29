// *Задача 62. Напишите программу, 
//которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
/*

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("[");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i < matrix.GetLength(0) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}


int[,] SpringNumberMatrix(int[,] matrixSp)
{
    int rowN = matrixSp.GetLength(0)-1;
    int columnN = matrixSp.GetLength(1)-1;

    int stopRow = rowN + 1;
    int stopColumn = columnN;

    int startIndexRow = 1;
    int startIndexColumn = 1;

    int i = -1;
    int j = 0;
    int stepPlus = 1;

    while ((stopRow >= 0) && (stopColumn >= 0))
    {

        for (int rowStep = 1; rowStep <= stopRow; rowStep++)
        {
            matrixSp[i + startIndexRow * rowStep, j] = stepPlus;
            stepPlus++;
        }

        i = i + startIndexRow * stopRow;
        startIndexRow = -startIndexRow;
        stopRow--;


        for (int columnStep = 1; columnStep <= stopColumn; columnStep++)
        {
            matrixSp[i, j + startIndexColumn * columnStep] = stepPlus;
            stepPlus++;
        }


        j = j + startIndexColumn * stopColumn;
        startIndexColumn = -startIndexColumn;
        stopColumn--;
    }
    return matrixSp;
}



int[,] matrix = CreateMatrixRndInt(4, 4, 0, 25);
int[,] matrixSp = SpringNumberMatrix(matrix);
PrintMatrix(matrixSp);
