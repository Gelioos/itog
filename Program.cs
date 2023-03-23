void MethodOneArray(string[] OneArray)
{
    Console.Write($"One array: ");
    for (int i = 0; i < OneArray.Length; i++) Console.Write($"{OneArray[i]} ");
    Console.WriteLine();
}

void MethodTwoArray(string[] TwoArray)
{
    Console.Write($"Two array: ");
    string[] newarr = new string[TwoArray.Length];
    for (int i = 0; i < TwoArray.Length; i++)
    {
        if (TwoArray[i].Length <= 3)
        {
            newarr[i] = TwoArray[i];
            Console.Write($"{newarr[i]} ");
        }
    }
    Console.WriteLine();
}

string[] array = { "hello_world", "objbinprogram", "1", "KZ", ":-)" , "13", "^_^", "Rus"};

Console.WriteLine();
MethodOneArray(array);
Console.WriteLine();
MethodTwoArray(array);
Console.WriteLine();
