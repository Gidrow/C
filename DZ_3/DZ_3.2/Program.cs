// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите x1: ");
double x1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y1: ");
double y1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z1: ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x2: ");
double x2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y2: ");
double y2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z2: ");
double z2 = double.Parse(Console.ReadLine()!);

double a = Math.Pow(x2 - x1, 2);

double b = Math.Pow(y2 - y1, 2);

double c = Math.Pow(z2 - z1, 2);

double result = Math.Sqrt(a + b + c);

var Res = result.ToString();


Console.WriteLine($"Расстояние между точками:  {Res[0]}{Res[1]}{Res[2]}{Res[3]}{Res[4]}"); 

