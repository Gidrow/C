
int numberA = new Random().Next(10, 99);
Console.WriteLine(numberA);

if (numberA > 10 && numberA < 99)
{
if (numberA / 10 > numberA % 10)
{
        Console.WriteLine("Первая цифра больше");
}

else

if (numberA / 10 == numberA % 10)
{
        Console.WriteLine("Цифры одинаковы");
}
else
Console.WriteLine("Вторая цифра больше");
}