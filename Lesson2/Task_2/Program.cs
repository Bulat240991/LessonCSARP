int N1 = int.Parse(Console.ReadLine()!);
int N2 = N1 / 10 % 10;
int N3 = N1 % 10;
Console.WriteLine(Math.Pow(N2,N3));