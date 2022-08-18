int[] ArrayCreation(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0, 101);
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

void FindNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i] == num) 
            {
                Console.WriteLine("Yes");
                return;
            }
    }
    Console.WriteLine("No");
}

int[] myarr = ArrayCreation(10);
int number = 5;
PrintArray(myarr);
FindNumber(myarr, number);