﻿int[] ArrayCreation(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(-100, 101);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void ReSignArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -1 * arr[i];
    }
}

int[] myarr = ArrayCreation(10);
PrintArray(myarr);
ReSignArray(myarr);
PrintArray(myarr);