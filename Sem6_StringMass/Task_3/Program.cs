// 3. Считать строку с консоли, состоящую из латинских
//    букв в нижнем регистре. Выяснить, сколько среди
//    введённых букв гласных.

string vowelsChars = "aoeiuy";

int CountVowelsCharInString(string str)
{
    int countVowelsChar = 0;
    // foreach (char ch in str)
    // {
    //     if (vowelsChars.Contains(ch))
    //     {
    //         countVowelsChar++;
    //     }
    // }
    // return countVowelsChar;
    for (int i = 0; i < str.Length; i++)
    {
        if (vowelsChars.Contains(str[i]))
        {
            countVowelsChar++;
        }
    }
    return countVowelsChar;
}

string inputString = Console.ReadLine()!;
Console.Write(CountVowelsCharInString(inputString));