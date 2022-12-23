// Доп. задача Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Пример:
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите десятичное число: ");
int N = int.Parse(Console.ReadLine()!);

string D = Convert.ToString(N, 2);

 Console.WriteLine();
Console.WriteLine($"Десятичное число {N} в двоичной системе: {D}");
 Console.WriteLine();