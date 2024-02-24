//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System.Runtime;
using static System.Console;

int num = int.Parse(ReadLine()!);
if (num % 7 == 0 && num % 23 == 0)
{
    WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    WriteLine($"Число {num} не кратно 7 и 23");
}