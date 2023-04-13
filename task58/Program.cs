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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}



int[,] array2d = CreateMatrixRndInt(4, 4, 1, 100);
PrintMatrix(array2d);
Console.WriteLine();

int[,] array2dd = CreateMatrixRndInt(4, 4, 1, 100);
PrintMatrix(array2dd);


int[,] resultMatrix = new int[4, 4];

MultiplyMatrix(array2d , array2dd, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);

void MultiplyMatrix(int[,] array2d,  int[,] array2dd, int[,] resultMatrix)

{

  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array2d.GetLength(1); k++)
      {
        sum += array2d[i,k] * array2dd[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
