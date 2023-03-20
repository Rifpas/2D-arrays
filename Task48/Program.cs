// задайте двумерный массив размера m на n,
// каждый элемент в массиве назодится по формуле Amn = m+n. 
// Выведите полученный массив


int[,] CreateMatrixSumIndex (int rows, int columns )
{
    int[,] matrix = new int[rows, columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = i + j;
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
int[,] array2D = CreateMatrixSumIndex(3, 4);
PrintMatrix(array2D);