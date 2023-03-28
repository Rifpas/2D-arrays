// Задайте значение N и M Напишите програму,которая 
// выведет все натуральные числа в промежутке от M до N


Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());

naturalNumbers(numberM, numberN);

void naturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1}  ");
        naturalNumbers(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
        naturalNumbers(num1, num2 - 1);
        Console.Write($"{num2}  ");
    }
    
    else
    {
        Console.Write($"{num1}  "); 
    }
}