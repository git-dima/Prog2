// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число!");
string value = Console.ReadLine();
int a = int.Parse(value);


if (a < 100 || a > 999)
{
    Console.WriteLine("введите трёхзначное число");
}
else
{
    int secondDigit = a / 10 % 10;
    Console.WriteLine(secondDigit);
}

