int N1 = int.Parse(Console.ReadLine()!);
if (N1 < 100)
{
    Console.WriteLine("No");
}
else
{
    Console.WriteLine((N1 / 100) % 10);
}