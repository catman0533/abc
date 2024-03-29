﻿int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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



void ReturnValueElemArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < 0 || i > matrix.GetLength(0) && j < 0 || j > matrix.GetLength(1))
            {
                Console.WriteLine("Такого элемента не существует");  
            }
                else
            {
                Console.WriteLine("Значение элемента массива  = {0}", matrix[i ,j]);
            }



        }
    }


}



    int[,] array2d = CreateMatrixRndInt(3, 4, 1, 100);
    PrintMatrix(array2d);
    Console.WriteLine();
    ReturnValueElemArray(array2d);
    PrintMatrix(array2d);