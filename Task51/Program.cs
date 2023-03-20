// Задайте двумерный массив 
// Найдите сумму элементов, находящихся на главной диагонали(0,0 1,1)

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

int SumElementsDiag (int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(i == j)
        {
          sum += matrix [i, j];
        }
    }
    }
    return sum;
}


int[,] array2D = CreateMatrixRndInt(3, 3, 1, 20);
PrintMatrix(array2D);
Console.WriteLine(" ");
int sumelements = SumElementsDiag(array2D);
Console.WriteLine($"{sumelements}");