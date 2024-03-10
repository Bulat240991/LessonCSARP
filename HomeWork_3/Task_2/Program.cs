// Задайте массив на 10 целых чисел. Напишите программу, которая определит количество чётных чисел в массиве.

int[] arr = new int[10];

Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
    arr[i] = rnd.Next(100);

Console.Write($"[{String.Join(',', arr)}]");

int j = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
        j++;
}
Console.WriteLine();
Console.WriteLine($"{j}");