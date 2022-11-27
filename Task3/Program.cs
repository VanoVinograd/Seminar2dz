// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 8)
{
    if (num > 0 && num < 6)
    {
        Console.WriteLine("нет");
    }

    else if (num > 5 && num < 8)
    {
        Console.WriteLine("да");
    }
}
else
{
    Console.WriteLine("Подсказка: число должно быть от 1 до 7");
}