


Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

int akkerman(int m, int n)
{
if (m == 0) 
    {
    return n + 1;
    }
else if (n == 0) 
    {
    return akkerman(m - 1, 1);
    }
else 
    {
    return akkerman(m - 1, akkerman(m, n - 1));
    }
}

Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");