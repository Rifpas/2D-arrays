// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write ("Введите номер строки ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите номер столбца ");
int j = Convert.ToInt32(Console.ReadLine());

if(i < 0 || j < 0 ) 
{
    {
        Console.WriteLine(" ** Не правильный ввод, введите положительное число ** ");
    }
    return;
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


bool FindElementByIndex (int[,] matrix, int i, int j)
{
    if ( i < matrix.GetLength(0) && j < matrix.GetLength(1)) return false; 
    {
        return true;
    }   
}



int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

Console.Write(FindElementByIndex(array2D, i, j) ? "Элемент отсутствует" : "Элемент присутствует ");