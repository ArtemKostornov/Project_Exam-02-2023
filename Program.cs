﻿
string[] array = { "1", "two", "3", "four", "five" };
string[] arr = new string[5];


string[] DoArr(string[] array, string[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[i] = array[i];
        }
        else arr[i] = " ";
    }
    return arr;
}
arr = DoArr(array, arr);

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}" + ",");
}
Console.Write("]");
Console.Write("->");
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] != " " )
    {
        Console.Write($"{arr[i]}" + ",");
    }
}

Console.Write("]");
