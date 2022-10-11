/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())*/
Console.WriteLine("Введите массив: ");
string text = Console.ReadLine();
 
string[] words = text.Split(new char[] { ' ' });
 
foreach (string s in words)
{
    Console.WriteLine($"->[{s}]");
}