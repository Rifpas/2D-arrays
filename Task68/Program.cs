// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))



Console.WriteLine("Введите положительное число M ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N ");
int numN = Convert.ToInt32(Console.ReadLine());

int ResaultAckermannFunction = AckermannFunction(numM, numN );
Console.WriteLine($"Функция Аккермана для чисел A({numM},{numN}) = {AckermannFunction(numM, numN )}");


int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
} 