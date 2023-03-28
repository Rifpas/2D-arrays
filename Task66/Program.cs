//  Задайте значения M и N. 
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//  Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число");
int number1 = Convert.ToInt32(Console.ReadLine());

int SumNaturalElements = SumElements (number, number1);
Console.Write($"Сумма натуральных элементов = {SumNaturalElements} ");

int SumElements(int num1, int num2)
{ 
     if (num1 > num2 ) return 0;
    return num2 + SumElements(num1, num2 - 1);
 }
    