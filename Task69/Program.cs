// напишите программу, которая будет принимать на вход два числа  а и в,
//  и возводит число А в целую степень В с помощью рекурсии
//  а = 3 в = 5  -- 243
//  а = 2 в = 3 -- 8


Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число");
int number1 = Convert.ToInt32(Console.ReadLine());

int MultiNum = PowNumber(number, number1);
Console.Write(MultiNum);

int PowNumber(int num1, int num2)
{
    if ( num2 == 0) return 1;
    
    else return checked (num1 * PowNumber(num1, num2 - 1)); /// checked защита от переполнения

}