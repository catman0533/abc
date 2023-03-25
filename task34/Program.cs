int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000 + 1);
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
int ArraySearch( int[] arr)
{
    int count = 0;
    for( int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 ==0)
        count ++;
    }
    return count;
}   




int[] array = CreateArrayRndInt(10, 100, 1000);
PrintArray(array);
int arraysearch = ArraySearch(array);
Console.WriteLine($"Количество четных чисел в массиве = {arraysearch}");
