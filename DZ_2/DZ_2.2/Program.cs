// Забаное решение

// Console.WriteLine("Введите трехзначное число ");
// int a = int.Parse(Console.ReadLine()!);
// int b;
// int c;


// b = (a / 100) * 100;

// c = (a-b)/10;

// Console.WriteLine(c);


Console.WriteLine("Введите трехзначное число ");
int a = int.Parse(Console.ReadLine()!);
int b = a / 100 % 10;
if ( b % 10 > 0  )
{
    Console.Write("Третье число ");
    Console.WriteLine(b);
}
else {
    Console.WriteLine("Третьего числа нет");
 }