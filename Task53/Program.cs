// задайте двумерный массив. Напищите программу которая 
// поменяет местами первую и последнюю строку массива.

void ReplaceFirstLastRows(int[,]arr2D)
{
    int FirstIndexRows = 0;
    int LastIndexRows = arr2D.GetLength(0) - 1;
    for (int i = 0; i < arr2D.GetLength(1); i++)
    {
        int temp = arr2D[FirstIndexRows, i];
        arr2D[FirstIndexRows, i] = arr2D[LastIndexRows, i];
        FirstIndexRows = LastIndexRows;
        arr2D[LastIndexRows, i] = temp;
    }
}



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine();
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

Console.WriteLine(" ");

ReplaceFirstLastRows(array2D);
PrintMatrix(array2D);