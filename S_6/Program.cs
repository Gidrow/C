// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]



// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33



// Задча 3. Задайте двумерный массив со случайными числами от -10 до 10. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12



// {
// Console.Write("[");
// for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
// Console.WriteLine($"{a[a.Length-1]}]");
// }
// int length = new Random().Next(3,11);
// int[] Array =new int[length];
// int count = 0;
// int sum = 0;


// for (int i=0; i<length; i++) 
// {
// Array[i] = new Random().Next(-10,11);
// }
// ArrayPrint(Array);

// for (int i=0; i<length; i++) 
// {
//     if (Array[i]>0)
//     {
//        count +=1;
//        sum += Array[i];
//     }
// }
// Console.Write("Сумма положительных элементов: " + Convert.ToDouble(sum)/count)



double[] array = new double[5];       

double Number = 0;
int count = 0;

Console.WriteLine();
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{

    double number = new Random().Next(-10, 11) + new Random().NextDouble();
    array[i] = Math.Round(number);


    Console.Write("  " + array[i] + "  ");     


    if (array[i] > 0) 

    {
    Number += array[i];
    count++;
    }

}

Console.WriteLine("]");
Console.WriteLine();

Console.WriteLine($"Cреднее арифметическое положительных элементов = {Math.Round((Number/count), 2)} ");
Console.WriteLine();


