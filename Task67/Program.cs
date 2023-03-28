// напишите программу, которая будет принимать на вход число и возвращать сумму ешо цифр
// 453 - 12
// 45 - 9


Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit = SumDigitNumber(number);
Console.Write(SumDigit);

int SumDigitNumber(int num)
{
    if ( num == 0) return 0;
    else return num % 10 + SumDigitNumber(num / 10);
}