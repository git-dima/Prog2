// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1->нет

Console.WriteLine("Введите число!");
string value = Console.ReadLine();
int a = int.Parse(value);

if (a > 7)
{
    Console.WriteLine("такого дня недели нет");
}
else if (a < 6)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да");
}

