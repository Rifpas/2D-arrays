// составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том
// сколько раз встречается элемент входных данных

//Array.Sort(array);

Console.Write ("Введите номер строки ");
int rowMatrix =Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите номер столбца ");
int colMatrix = Convert.ToInt32(Console.ReadLine());



int[,] matrixNew = CreateMatrixRndInt( rowMatrix, colMatrix, 1, 10);
PrintMatrix(matrixNew);
Console.WriteLine("");

int[] arr = Array2DInArray(matrixNew);
PrintArray(arr);

Array.Sort(arr);/// сортирует массив, от мин до макс, только для одномерного массива
PrintArray(arr);
dictionary(arr);

void dictionary(int[] arr)
{
    int count = 1;
    int value = arr[0];
    
    for (int i = 1; i < arr.Length; i++)
    {
        if(value == arr[i]) count++;
        else
        {
            Console.WriteLine($"{value} ------> {count}");
            value = arr[i];
            count = 1;
        }

    }
    Console.WriteLine($"{value} ------> {count}");
}


int[] Array2DInArray(int[,] matrix)
{
    int[]array = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array [count] = matrix[i, j];
            count++;
            
        }
    }
    return array;
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