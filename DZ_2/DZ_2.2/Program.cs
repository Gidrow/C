Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string b = a.ToString();

if (a > 100)
{
    Console.WriteLine(b[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}