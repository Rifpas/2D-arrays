﻿//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



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

double ArithmeticMeanColumn(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double mean = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
        sum += matrix[i, j];   
        mean = sum / matrix.GetLength(1);   
        } 
    
        
    // mean = sum / matrix.GetLength(1);
       
    }
    return Math.Round(mean, 1);
}   

int[,] array2D = CreateMatrixRndInt(2, 3, 1, 10);
PrintMatrix(array2D);
Console.WriteLine(" ");

double sumelements = ArithmeticMeanColumn(array2D);
Console.WriteLine($"{sumelements}");

