// Задача 21  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки Ах ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Аy ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Аz ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Bх ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки By ");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки Bz ");
int Bz = Convert.ToInt32(Console.ReadLine());

double distans = Math.Round(Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2)),2);
Console.WriteLine($"{distans} ");









