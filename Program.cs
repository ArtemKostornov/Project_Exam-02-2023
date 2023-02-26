

string[] array = { "1", "two", "3", "four", "five" };



string[] DoArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array[i] = array[i];
        }
        else array[i] = " ";
    }
    return array;
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}" + ",");
}
Console.Write("]");
Console.Write("->");
Console.Write("[");



array = DoArr(array);


for (int i = 0; i < array.Length; i++)
{
    if (array[i] != " " )
    {
        Console.Write($"{array[i]}" + ",");
    }
}

Console.Write("]");
