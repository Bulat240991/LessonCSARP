// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

using static System.Console;

int num = int.Parse(ReadLine()!);
string allnums = "";

while (num > 0)
{
    allnums = num % 10 + "," + allnums;
    num /= 10;
}
Write(allnums);