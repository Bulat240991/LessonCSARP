int[] arr = new int[] {6, 5, 7, 8, 3};
int num = int.Parse(Console.ReadLine()!);

string f = "Нет";

for (int i = 0; i < arr.Length; i++)
{
    if (num == arr[i])
    {
        f="Да";
    }
}

Console.WriteLine(f);
