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
    int rowLastIndex = matrixSp.GetUpperBound(0); 
    int columnLastIndex = matrixSp.GetUpperBound(1);

    int maxIndxRow = rowLastIndex + 1;
    int maxIndxColumn = columnLastIndex;
    
    int startIndexRow = 1;
    int startIndexColumn = 1;

    int i = -1;
    int j = 0;
    int count = 1;

    while ((maxIndxRow >= 0) && (maxIndxColumn >= 0))
    {
        for (int rowCount = 1; rowCount <= maxIndxRow; rowCount++)
        {
            matrixSp[i + startIndexRow * rowCount, j] = count;
            count++;
        }

        i = i + startIndexRow * maxIndxRow;
        startIndexRow = -startIndexRow;
        maxIndxRow--;

        for (int columnCount = 1; columnCount <= maxIndxColumn; columnCount++)
        {
            matrixSp[i, j + startIndexColumn * columnCount] = count;
            count++;
        }

        j = j + startIndexColumn * maxIndxColumn;
        startIndexColumn = -startIndexColumn;
        maxIndxColumn--;
    }
    return matrixSp;
}


int[,] matrix = CreateMatrixRndInt(4, 4, 0, 25);
int[,] matrixSp = SpringNumberMatrix(matrix);
PrintMatrix(matrixSp);