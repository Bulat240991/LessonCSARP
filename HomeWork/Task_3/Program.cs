// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа

using static System.Console;

WriteLine("Введите двухзначное число");
int num = int.Parse(ReadLine()!);
while (num < 10 || num > 99)
{
    WriteLine("Введите двухзначное число");
    num = int.Parse(ReadLine()!);
}

int num1 = num % 10;
int num2 = num / 10;
if (num1 > num2)
{
    WriteLine($"{num1} большая цифра числа {num}");
}
else
{
    WriteLine($"{num2} большая цифра числа {num}");
}
 