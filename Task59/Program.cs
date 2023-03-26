// Задайте двумерный массив из целых чисел.
// напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива

int[,] matrixNew = CreateMatrixRndInt( 4, 4, 1, 10);
PrintMatrix(matrixNew);
Console.WriteLine("");

int[] MinElemIndex = minElemIndex(matrixNew);
int[,] arrayNew = DeleteMinRowColumn(matrixNew, MinElemIndex[0], MinElemIndex[1] );
PrintMatrix(arrayNew);


int[,] DeleteMinRowColumn(int[,] arr2D, int rowDel, int columnDel)
{
    int[,] arrayNew = new int[arr2D.GetLength(0) - 1, arr2D.GetLength(1) - 1];
    int m = 0, n = 0;

    for (int i = 0; i < arrayNew.GetLength(0); i++)
    {
        if (m == rowDel) m++;
        for (int j = 0; j < arrayNew.GetLength(1); j++)
        {
            if(n == columnDel) n++;
            arrayNew[i, j] = arr2D[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return arrayNew;
}

int[] minElemIndex(int[,] arr2D)
{
    int row = 0;
    int column = 0;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (arr2D[i, j] < arr2D[row, column])
            {
                row = i;
                column = j;
            }
        }
    }
    return new int[]{row, column};
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