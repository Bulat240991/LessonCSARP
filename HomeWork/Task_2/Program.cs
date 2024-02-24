﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

using static System.Console;

WriteLine("Введите число X");
int X = int.Parse(ReadLine()!);

WriteLine("Введите число Y");
int Y = int.Parse(ReadLine()!);
if (X == 0 || Y == 0)
{
    Write("Выберете точку координат не равную 0");
}
else if ((X > 0 && Y > 0))
{
    Write("точка находится в I координатной четверти плоскости");
}
else if ((X < 0 && Y > 0))
{
    Write("точка находится в II координатной четверти плоскости");
}
else if ((X < 0 && Y < 0))
{
    Write("точка находится в III координатной четверти плоскости");
}
else if ((X > 0 && Y < 0))
{
    Write("точка находится в IV координатной четверти плоскости");
}