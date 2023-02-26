# Project_Exam-02-2023
# ОПИСАНИЕ РЕШЕНИЯ ЗАДАЧИ
## Создаём строчный массив и присваиваем ему занчиние
```C#
string[] array = {"1", "two", "3", "four", "five" };
```
## Затем создаём метод, который из имеющегося массива строк формирует массив из строк длина которых меньше либо равна 3 символа.
```C#
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
```
## Когда метод готов, можно выводить первоначальный массив
```C#
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}" + ",");
}
Console.Write("]");
Console.Write("->");
Console.Write("[");
```
## Теперь преобразуем массив с помощью метода
```C#
array = DoArr(array);
```
## Выводим преобразованный массив
```C#
for (int i = 0; i < array.Length; i++)
{
    if (array[i] != " " )
    {
        Console.Write($"{array[i]}" + ",");
    }
}
Console.Write("]");
```
----
## Программа выдаст:
