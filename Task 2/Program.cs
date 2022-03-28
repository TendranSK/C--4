/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число:  ");

int value = Convert.ToInt32(Console.ReadLine());

int valueSum = 0;

int temp = value;

while (value > 0)
{
    valueSum += value %10;
    value /= 10;

}

Console.WriteLine("Сумма цифр числа {0} равна {1}",temp,valueSum);