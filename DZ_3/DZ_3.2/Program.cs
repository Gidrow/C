// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double a = Math.Pow(x2 - x1, 2);

double b = Math.Pow(y2 - y1, 2);

double c = Math.Pow(z2 - z1, 2);

double result = Math.Sqrt(a + b + c);

var Res = result.ToString();

// Console.Write("Длинна:" + Res[0]);
// Console.Write(Res[1]); 
// Console.Write(Res[2]); 
// Console.Write(Res[3]);  
// Console.Write(Res[4]);

Console.WriteLine($"Расстояние между точками:  {Res[0]}{Res[1]}{Res[2]}{Res[3]}{Res[4]}"); 


