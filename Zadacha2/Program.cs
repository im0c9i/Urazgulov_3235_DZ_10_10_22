/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

System.Console.WriteLine("Введите число ");
int FerstNumber = int.Parse(Console.ReadLine());
int count = 0;
while (FerstNumber > 0)
{
    count = count + FerstNumber%10;
    FerstNumber = FerstNumber/10;
}
Console.WriteLine($"Summ цифр в числе = {count}");
