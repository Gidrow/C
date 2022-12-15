Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите первое число: ");
int c = int.Parse(Console.ReadLine()!);

int max;
int min;

min = 1;
max = 1;

if(b>a)
{
    max = b;
}
else
{
    max = a;
}

if(max<c)
{
    max = c;
}

Console.Write("Максимальное число:  ");
Console.Write(max);

