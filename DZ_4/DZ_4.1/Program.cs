// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow!

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);



Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

int TEMP = A;

for (int count = 1; count < B; count++)
{
    A = TEMP * A;
}

Console.WriteLine($"Число A возведенное в натуральную степень B = {A}");