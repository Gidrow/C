Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);

if (a > 99 && a < 1000)
{
    int b = a / 100 * 10 + a % 10;
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Введино неверное число");

}