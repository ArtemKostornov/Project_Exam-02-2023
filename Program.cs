
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
    }
    return arr;
}