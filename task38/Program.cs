double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[10];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");

}

double DifferenceArrayElem(double[] arr)
{
    double max = arr[0];
    double min = arr[0]; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    return max - min;
}
double[] array = CreateArrayRndDouble(10, 3 , 35);
PrintArrayDouble(array);
double differenceArrayElem = DifferenceArrayElem( array);
Console.WriteLine
($"Разность между максимальным и минимальным элементом = {differenceArrayElem }");



