// PrintMessage("Hello work");
// PrintMessage("Hello METANIT.COM");    // Hello METANIT.COM
// PrintMessage("Hello C#");             // Hello C#


// void PrintMessage(string message)
// {
//     Console.WriteLine(message);
// }

// Console.WriteLine();

// PrintMessage("Hello work");
// PrintMessage("Hello METANIT.COM");    // Hello METANIT.COM
// PrintMessage("Hello C#");             // Hello C#



// void Sum(int x, int y)
// {
//     int result = x + y;
//     Console.WriteLine($"{x} + {y} = {result}");
// }

// Sum(10, 15);    // 10 + 15 = 25



// void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = { x + y }");

// int a = 10, b = 15, c = 6;
// Sum(a, b);                  // 10 + 15 = 25
// Sum(3, c);                  // 3 + 6 = 9
// Sum(14, 4 + c);             // 14 + 10 = 24


// void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

// int a = 10, b = 15, c = 6;
// Sum(a, b);                  // 10 + 15 = 25
// Sum(3, c);                  // 3 + 6 = 9
// Sum(14, 4 + c);             // 14 + 10 = 24
// Console.WriteLine();



// string GetMessage()
// {
//     return "Hello";
// }

// void PrintMessage(string message)
// {
//     Console.WriteLine(message);
// }
// PrintMessage(GetMessage());



// int Sum(int x, int y)
// {
//     return x + y;
// }
 
// int result = Sum(10, 15);   // 25


// Console.WriteLine(result);   // 25
 
// Console.WriteLine(Sum(5, 6));   // 11






// string text = "aq aq aq aq";


// string replace(string text1, char old, char new1)
// {
//     string result = String.Empty;

//     int length = text1.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text1[i] == old) result = result + $"{new1}";
//         else result = result + $"{text1[i]}";
//     }

//     return result;

// }

// string newText = replace(text, 'a', 'b');

// Console.WriteLine(newText);
// Console.WriteLine();







// int[] array = new int[10];
// Random Random = new Random();

// double sumElem = 0;
// double sumElem2 = 0;

// Console.WriteLine();
// Console.Write("[");

// for (int i = 0; i < array.Length; i++)
// {

//     array[i] = Random.Next(-10, 10);
//     Console.Write("  " + array[i] + "  ");

//     if (array[i] % 2 > 0 && array[i] > 0)
//     {
//         sumElem = sumElem + array[i];
//     }

//     if (array[i] % 2 < 0 && array[i] < 0)
//     {
//         sumElem2 = sumElem2 + array[i];
//     }
// }
// Console.WriteLine("]");
// Console.WriteLine();

// Console.WriteLine($"Найдите сумму элементов, стоящих на нечётных позициях: {sumElem + sumElem2}");







// Console.Write("Введите число N ");
// int n = int.Parse(Console.ReadLine());

// Console.Write("Введите число N ");
// int m = int.Parse(Console.ReadLine());



// Console.WriteLine();
// Console.Write("[");


// int[,] array = new int[n, m];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[n, m] = new Random().Next(0, 10);
//         Console.Write("  " + array[i, j] + "  ");
//     }
// }

// Console.WriteLine("]");
// Console.WriteLine();









for (int i = 0; i < 4; i++)
{
    int summ = 0;
    int count = 0;

    int SummMeth()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {

                if (count == j) summ = summ + array[i, j];

            }

        }
        return summ;
    }

    int ys = SummMeth();
    Console.WriteLine(ys);




    
}

