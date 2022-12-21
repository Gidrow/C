// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
var B = A.ToString();

int X = B.Length;

int Temp = 0;



for (int i = 0; i < X; i++)
{
    string Temp2 = Convert.ToString(B[i]);
    int Temp3 = Convert.ToInt32(Temp2);
    Temp = Temp + Temp3;
}



Console.WriteLine(Temp);