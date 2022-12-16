Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);

int b = a % 100;

int c = (b - (b % 10)) / 10; // Прим. a = 321     b = 21         c(2)= (21 - 1) / 10 

Console.WriteLine("Второе число: " + c);


