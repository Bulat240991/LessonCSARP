// 2. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void sumElNums (int num){
    if (num == 0){
        return;
    }
      sumElNums(num - 1) ;
    Console.Write(num + " ");
}

Console.WriteLine($"введите число: ");
int num = int.Parse(Console.ReadLine()!);

sumElNums(num);