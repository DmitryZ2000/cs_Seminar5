int[] ArrayCreation(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(-10, 11);
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

int[] myarr = ArrayCreation(5);
PrintArray(myarr);

void ReSignArray(int[] arr)
{
        for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = -1 *arr[i];
    }
}
ReSignArray(myarr);
PrintArray(myarr);