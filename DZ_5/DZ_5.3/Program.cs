// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// double[] array = new double[5, 10];
// Random Random = new Random();

// int Max = 1;
// int Min = 100;

// Console.WriteLine();
// Console.Write("[");

// for (int i = 0; i < array.Length; i++)
// {

//     array[i] = Random.Next(1, 101);
//     Console.Write("  " + array[i] + "  ");

//     if (array[i] > Max)
//     {
//         Max = array[i];
//     }

//     if (array[i] < Min)
//     {
//         Min = array[i];
//     }

// }
// Console.WriteLine("]");
// Console.WriteLine();
// Console.WriteLine($"Элемент массива с  минимальным  значением: {Min}");
// Console.WriteLine($"Элемент массива с максимальным  значением: {Max}");

// Console.WriteLine($"Разница между максимальным  {Max} и минимальным {Min} элементов массива.");
// Console.WriteLine();

// Console.WriteLine($"{Max} - {Min} = {Max -Min}"); 
// Console.WriteLine();

double[] array = new double[10];

double Max = 1;
double Min = 100;

Console.WriteLine();
Console.Write("[");

Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.NextDouble() * 100;   // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
    Console.Write("{0,6:F2}", array[i]);

    if (array[i] > Max)
    {
        Max = array[i];
    }

    if (array[i] < Min)
    {
        Min = array[i];
    }
}


Console.WriteLine("]");
Console.WriteLine();

Console.WriteLine($"Элемент массива с  минимальным  значением: {Min}");
Console.WriteLine();

Console.WriteLine($"Элемент массива с максимальным  значением: {Max}");
Console.WriteLine();

Console.WriteLine($"Разница между максимальным  {Max} и минимальным {Min} элементов массива.");
Console.WriteLine();

Console.WriteLine($"{Max} - {Min} = {Max -Min}"); 
Console.WriteLine();
