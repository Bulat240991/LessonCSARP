// 1. Задайте массив символов (тип char []).
//    Создайте строку из символов этого массива.
//    Конструктор строки вида string(char []) не использовать.

char[] chars = new [] {'a','b','c','d'};
string Tostring(char[] chars){
    string str = "";
for (int i = 0; i < chars.Length; i++) {
    str += chars[i];
}
return str;
}

Console.WriteLine(Tostring(chars));