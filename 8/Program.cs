// Задача 19  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("ВВЕДИТЕ 5-ЗНАЧНОЕ ЧИСЛО ");
int number = Convert.ToInt32(Console.ReadLine());
int A = number/10000;
Console.WriteLine($"{A}");
int B = number%10;
Console.WriteLine($"{B}");
int C = (number/1000)%10;
Console.WriteLine($"{C}");
int D = (number/10)%10;
Console.WriteLine($"{D}");
if ( A == B & C == D)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}