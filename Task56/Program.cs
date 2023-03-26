// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrixNew = CreateMatrixRndInt( 5, 4, 1, 10);
PrintMatrix(matrixNew);
Console.WriteLine("");


int[] sumLine = SumOfLine(matrixNew);
PrintArray(sumLine);

int MinSumRow = MinSumLine(sumLine);
Console.WriteLine($"Наименьшая сумма в строке - {MinSumRow}");

int MinSumLine(int[] sumRow )
{
    int sum = sumRow[0];
    int Index = 0;

    for (int i = 0; i < sumRow.Length; i++)
    {
        if (sumRow[i] < sum)
        {
            sum = sumRow[i];
            Index = i;
        }
    }
    return Index + 1;
}

int[] SumOfLine(int[,] matrix)
{
    int[]sumRow = new int[matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i, j];
        }
    }
    return sumRow;
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

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("]");
}