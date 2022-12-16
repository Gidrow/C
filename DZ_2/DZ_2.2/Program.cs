Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int b;
int c;


b = (a / 100) * 100;

c = (a-b)/10;

Console.WriteLine(c);