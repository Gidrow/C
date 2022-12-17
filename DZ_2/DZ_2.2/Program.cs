Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
var b = a.ToString();

if (a > 99)
{
    Console.WriteLine("Третья цифра: " + b[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}