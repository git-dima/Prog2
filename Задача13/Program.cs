// Задача 13:Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число!");
string value = Console.ReadLine();
int a = int.Parse(value);

if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int digitIndex = 2; // индекс нужной цифры
    int digit = value.ToString()[digitIndex] - '0';

    Console.WriteLine(digit);
}