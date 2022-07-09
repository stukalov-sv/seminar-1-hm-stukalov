/*
Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее
*/

Console.WriteLine("Введите число 1: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");

int number1 = Convert.ToInt32(Console.ReadLine());

if (number > number1)
{
    Console.WriteLine("max = " + number);
    Console.WriteLine("min = " + number1);
}
else
{
    Console.WriteLine("max = " + number1);
    Console.WriteLine("min = " + number);
}