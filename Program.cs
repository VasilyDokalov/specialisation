void PrintStringArray(string[] stringArray)
{
    Console.Write("[ ");
    for (int i=0; i<stringArray.Length; i++)
    {
        Console.Write($"\"{stringArray[i]}\"");
        if (i != stringArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int searchStringsWithSizeLessOrEqual4(string[] stringArray)
{
    int numberOfStrings = 0;
    for (int i=0; i<stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 4)
        {
            numberOfStrings++;
        }
    }
    return numberOfStrings;
}

string[] createArrayWithSizeLessOrEqual4(string[] stringArray, int sizeNewArray)
{
    string[] newStringArray = new string[sizeNewArray];
    int j=0;
    for (int i=0; i<stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 4)
        {
            newStringArray[j] = stringArray[i];
            j++;
        }
    }
    return newStringArray;
}

string[] stringArray = { "Rome", "Rio", "Moscow", "Austin", "Brno" };
PrintStringArray(stringArray);
int sortedNewArray = searchStringsWithSizeLessOrEqual4(stringArray);
string[] newStringArray = createArrayWithSizeLessOrEqual4(stringArray, sortedNewArray);
Console.Write(" => ");
PrintStringArray(newStringArray);
Console.WriteLine();