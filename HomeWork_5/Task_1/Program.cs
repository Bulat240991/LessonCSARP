

int[,] CreateMatrix(int rowCount, int columnCount)
    {
        int[,] matrix = new int[rowCount, columnCount];
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(10, 100);
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
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

int ElementMatrix(int[,] matrix, int rowIndex, int columnIndex)
    {
        int result = 0; // Присвоение значения по умолчанию
        if (rowIndex < matrix.GetLength(0) && columnIndex < matrix.GetLength(1))
        {
            result = matrix[rowIndex, columnIndex];
        }
        else if (rowIndex >= matrix.GetLength(0))
            Console.WriteLine("Некорректный ввод для позиции элемента по строке.");
        else if (columnIndex >= matrix.GetLength(1))
            Console.WriteLine("Некорректный ввод для позиции элемента по столбцу.");

        return result;
        
    }
        int rowCount, columnCount, rowIndex, columnIndex;
        Console.WriteLine($"Введите размер матрицы по строкам: ");
        rowCount = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine($"Введите размер матрицы по столбцам: ");
        columnCount = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine($"Введите позицию элемента по строке: ");
        rowIndex = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine($"Введите позицию элемента по столбцу: ");
        columnIndex = int.Parse(Console.ReadLine()!);

        int[,] matrix = CreateMatrix(rowCount, columnCount);
        PrintMatrix(matrix);
        int result = ElementMatrix(matrix, rowIndex, columnIndex);
        Console.WriteLine($"Элемент в матрице: {result}");
    

