int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int C = int.Parse(Console.ReadLine()!);

if (A < B)
{
    A = B;
}
if (A < C)
{
    A = C;
}
Console.WriteLine($"Max= {A}");