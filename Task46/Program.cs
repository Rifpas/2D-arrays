// задайте двумерный массив размером MxN,
// заполненый случайными числами m = 3, n = 4


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

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
// Console.WriteLine("Enter n:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter m:");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,]arr=new int [n, m];
// int []sum=new int [m];
// Random ran = new Random();

// for (int i=0; i<n; i++)
// {
//     for(int j=0; j<m; j++)
//     {
//         arr[i, j] = ran.Next(0, 100);

//         Console.Write(arr[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// for (int i=0; i<m; i++)
// {
//     for(int j=0; j<n; j++)
//     {
//         sum[i] += arr[j, i];
//     }
// }

// for (int i=0; i<m; i++)
// {
//     Console.Write(sum[i] / n + " ");
// }
// Console.ReadLine();