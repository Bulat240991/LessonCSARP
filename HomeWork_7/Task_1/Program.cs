// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


int sumNums (int M, int N)
{
    if (M > N)    {
        return 0;
    }
     
    return sumNums(M + 1, N) + M;
    
}

Console.WriteLine($"введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine($"введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write($"sum of numbers from M to N = {sumNums(M, N)}");



