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

int searchStringsWithSizeLessOrEqual3(string[] stringArray)
{
    int numberOfStrings = 0;
    for (int i=0; i<stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            numberOfStrings++;
        }
    }
    return numberOfStrings;
}

string[] createArrayWithSizeLessOrEqual3(string[] stringArray, int sizeNewArray)
{
    string[] newStringArray = new string[sizeNewArray];
    int j=0;
    for (int i=0; i<stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            newStringArray[j] = stringArray[i];
            j++;
        }
    }
    return newStringArray;
}

string[] stringArray = { "C#", "Python", "Java", "C++", "SQL" };
PrintStringArray(stringArray);
int sortedNewArray = searchStringsWithSizeLessOrEqual3(stringArray);
string[] newStringArray = createArrayWithSizeLessOrEqual3(stringArray, sortedNewArray);
Console.Write(" => ");
PrintStringArray(newStringArray);
Console.WriteLine();