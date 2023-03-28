// Задайте значение N Напишите програму, 
// которая выведет все натуральные числа в промежутке от 1 до N


Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());

naturalNambers(number);

void naturalNambers(int num)
{
    if ( num == 0) return;
    Console.Write($"{num}  ");  // от n до 1
    naturalNambers (num - 1);
    //Console.Write($"{num}  "); от 1 до n
}