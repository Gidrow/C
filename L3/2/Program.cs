string text = "aq aq aq aq";


string replace(string text1, char old, char new1)
{
    string result = String.Empty;

    int length = text1.Length;

    string part1 = "HRREG"; //

    for (int i = 0; i < length; i++)
    {
        if (text1[i] == old) result = result + $"{new1}";
        else result = result + $"{text1[i]}";

        part1 = part1 + "O";
        Console.WriteLine(part1);
        
    }


    return result;
    
    

}

string newText = replace(text, 'a', 'b');

Console.WriteLine(newText);
Console.WriteLine();

