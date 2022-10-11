string[] ParseArray(string[] inputArray)
{
    int n = 0;
    int array_length = 0;
    foreach (var item in inputArray) if (item.Length <= 3) array_length++;
    string[] resultArray = new string[array_length];
    foreach (var item in inputArray)
    {
        if (item.Length <= 3) {
            resultArray[n] = item;
            n++;
        }
    }

    return resultArray;
}
string[] firstSome = {"Moscow", "London", "Lin", "bl", "GI"};

Console.WriteLine($"[{String.Join(", ", ParseArray(firstSome))}]");


