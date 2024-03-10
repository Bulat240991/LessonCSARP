// Задайте одномернвый массив из 10 целых чисел от 1 до 100. Найдите количевтво элементов массива, значения которых лежат в отрезке [20,90]

int k = 0;
int n = 10;
// int max = 100;

int[] array = new int[n];

/*  
for (int i = 0; i < n; i++)
    array[i] = Random.Shared.Next(max);
*/

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(1, 101);

Console.WriteLine($"[{String.Join(',', array)}]");

for (int j = 0; j < array.Length; j++)
{
    if (array[j] >= 20 && array[j] <= 90)
        k++;
}

Console.WriteLine($"{k}");