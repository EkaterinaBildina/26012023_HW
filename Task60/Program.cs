// *Задача 60. ...
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] Create3DMatrixRndInt(int rows, int columns, int volume, int min, int max)
{
    int[,,] matrix3D = new int[rows, columns, volume];
    Random rnd = new Random();

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix3D;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],5} ({i},{j},{k})");
                else Console.Write($"{matrix[i, j, k],5} ({i},{j},{k}) ");
            }

        }
        Console.WriteLine("]");
    }
}


int[,,] matrix3D = Create3DMatrixRndInt(3, 3, 3, 10, 99);
PrintMatrix(matrix3D);




