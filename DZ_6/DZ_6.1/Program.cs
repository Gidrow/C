// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3




Console.WriteLine("Введите числа через пробел: ");
string inputText = Console.ReadLine(); // "4 5 2"

string[] stringArray = inputText.Split(' '); // ["4", "5", "2"]

int[] arr = new int[stringArray.Length];

int count = 0;

Console.WriteLine();
Console.Write("[");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(stringArray[i]);
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) count++;

    Console.Write(arr[i] + " ");

}

Console.WriteLine("]");
Console.WriteLine();

Console.WriteLine($"Чисел больше 0: {count}");
 Console.WriteLine();
