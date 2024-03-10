// 1. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.


int sumElNums (int num){
    if (num == 0){
        return 0;
    }
    return sumElNums(num / 10) + (num % 10);
}

Console.WriteLine($"введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine(sumElNums(num));