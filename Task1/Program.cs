// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if ((num > 99 && num < 1000) || (num > -1000 && num < -99))
{
    int num1 = (num / 100) * 10;
    int num2 = num / 10;
    Console.WriteLine(num2 - num1);
}
else
{
    Console.WriteLine("число не трезначное");
}