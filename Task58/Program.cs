// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Матрицы можно умножить только ,
 // когда число столбцов матриц равный

// Для того, чтобы умножить А и В, 
// нужно взять строку в первой матрице и столбец во второй, 
// перемножить одинаковые элементы и сложить полученные произведения.

int[,] MatrixOne = CreateMatrixRndInt( 2, 2, 1, 4);
PrintMatrix(MatrixOne);
Console.WriteLine("");

int[,] MatrixTwo = CreateMatrixRndInt( 2, 2, 1, 4);
PrintMatrix(MatrixTwo);
Console.WriteLine("Результат произведений двух матриц");

int[,] ResaultMatrix = MultiplicationMatrix (MatrixOne, MatrixTwo);
PrintMatrix(ResaultMatrix);

int[,] MultiplicationMatrix(int[,] MatrixOne, int[,] MatrixTwo)
{

    int row = (MatrixOne.GetLength(0) >= MatrixTwo.GetLength(0)) ? MatrixOne.GetLength(0) : MatrixTwo.GetLength(0);
    int col = (MatrixOne.GetLength(1) >= MatrixTwo.GetLength(1)) ? MatrixOne.GetLength(1) : MatrixTwo.GetLength(1);

    int[,] multMatrix = new int[row, col];

    if (MatrixOne.GetLength(1) == MatrixTwo.GetLength(0))
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                for (int k = 0; k < MatrixTwo.GetLength(0); k++)
                {
                    multMatrix[i, j] += MatrixOne[i, k] * MatrixTwo[k, j];
                }
            }
        }
    }
    return multMatrix;
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