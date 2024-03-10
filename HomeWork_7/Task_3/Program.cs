// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] Array = new int[] { 2, 6, 8, 4, 3, 7, 6, 3 };
int i = Array.Length;
void arrayRevers(int[] Array, int i)
{
    if (i == 0) return;
    Console.Write($"[{String.Join(',', Array[i - 1])}]");
    arrayRevers(Array, i - 1);

}

arrayRevers(Array, i);