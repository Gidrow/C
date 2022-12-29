// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 2: Задайте значение N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от 1 до N.

// M = 1; N = 15 -> 120



// Console.Clear();
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());


// string PrintNumber(int start, int end)
// {
//     if (start == end) return end.ToString();
//     return (start + " " + PrintNumber(start + 1, end)); // "3  2  1"
// }
// Console.WriteLine(PrintNumber(1, n));



// int PrintNumbers(int start, int end)
// {
//     if (start == end) return end;

//     return (start + PrintNumbers(start + 1, end)); //  
// }

// Console.WriteLine(PrintNumbers(1, n));





// // int PrintNumbers(int start, int end, int temp, int sumN)
// // {
// //     if (start == end) return end;
// //     temp = start;
// //     sumN = sumN + temp;
// //     return (start  + PrintNumbers(start + 1, end, temp, sumN)); // "3  2  1"
// // }





// /Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintNumbers(1, n));

string PrintNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    string answer = start + " " + PrintNumbers(start + 1, end);
    return answer; // "3  2  1"
}

Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(n));

string PrintNumbers(int number)
{
    if (number == 1) return "1";
    string answer = number + " " + PrintNumbers(number - 1);
    return answer; // "3  2  1"
}

Задача 2: Задайте значение N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от 1 до N.
M = 1; N = 15 -> 120

Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumbers(1, n));

int SumNumbers(int start, int end)
{
    if (start == end) return end;
    int answer = start + SumNumbers(start + 1, end);
    return answer;
}
