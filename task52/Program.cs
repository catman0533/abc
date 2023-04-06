int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)

{

    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }


}

double ArithmeticMeanElemColumnsArray(int[,] matrix)
{
 double sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
           
        }
        sum =  sum / matrix.GetLength(0);
        sum = Math.Round(sum);
    }
    return sum; 

}
    



int[,] array2d = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2d);
Console.WriteLine();
// int sumElementOfDigonal = SumElementOfDigonal(array2d);
// Console.WriteLine($"{sumElementOfDigonal}");
double arithmeticMeanElemColumnsArray = ArithmeticMeanElemColumnsArray (array2d);
// Console.WriteLine($"{  sum / matrix.GetLength(0)}");
Console.WriteLine($"{arithmeticMeanElemColumnsArray}");