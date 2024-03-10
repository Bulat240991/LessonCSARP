// See https://aka.ms/new-console-template for more information


int[,] CreateMatrix(int rowCount, int columCount)
{
    int[,] matrix = new int[rowCount,columCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(10,100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    
}

int rowCount = int.Parse(Console.ReadLine()!);
int columCount = int.Parse(Console.ReadLine()!);


int[,] matrix = CreateMatrix(rowCount, columCount);
PrintMatrix(matrix);
