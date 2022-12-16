Console.WriteLine("Число");
int a = int.Parse(Console.ReadLine()!);

if (a>1 && a<7)
{
if (a == 1)  Console.WriteLine("Нет");
if (a == 2)  Console.WriteLine("Нет");
if (a == 3)  Console.WriteLine("Нет");
if (a == 4)  Console.WriteLine("Нет");
if (a == 5)  Console.WriteLine("Нет");
if (a == 6)  Console.WriteLine("Да");
if (a == 7)  Console.WriteLine("Да");
}
else 
{
   Console.WriteLine("Введено неверное число"); 
}