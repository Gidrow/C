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






string text = "aq aq aq aq";


string replace(string text1, char old, char new1)
{
    string result = String.Empty;

    int length = text1.Length;
    for (int i = 0; i < length; i++)
    {
        if (text1[i] == old) result = result + $"{new1}";
        else result = result + $"{text1[i]}";
    }

    return result;

}

string newText = replace(text, 'a', 'b');

Console.WriteLine(newText);
Console.WriteLine();

