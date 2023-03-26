int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(-7, 7 + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
        sum = sum + arr[i];
    return sum;    
}

int[] array = CreateArrayRndInt(10, -7, 7);
PrintArray(array);
int sumelem = SumElem(array);
Console.WriteLine($" Сумма элементов стоящих на нечетных позициях = {sumelem}");


