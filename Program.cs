// See https://aka.ms/new-console-template for more information
Console.Write("Input array length --> ");
int lengthArrray = int.Parse(Console.ReadLine()!);
string[] arrayWords = new string [lengthArrray];
arrayWords=CreateArray(arrayWords);
PrintArray(arrayWords);
Console.WriteLine();
arrayWords=SortArray(arrayWords);
PrintArray(arrayWords);
Console.WriteLine();

string[] CreateArray(string[] strArray)
{
    for(int i=0; i<strArray.Length; i++)
    {
        strArray[i]= Console.ReadLine();
    }
    return strArray;
}

void PrintArray (string[] strArray)
{
    for (int i=0; i<strArray.Length; i++)
    {
        Console.Write($"{strArray[i]} ");
    }
}

string[] SortArray(string[] strArray)
{
    int j=0;
    string[] strSortArray = new string[strArray.Length];
    for(int i=0; i<strArray.Length; i++)
    {
        if (strArray[i].Length<=3)
        {
            strSortArray[j]=strArray[i];
            j++;
        }
    }
    return strSortArray;
}