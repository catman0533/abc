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



int[,] array2d = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2d);
Console.WriteLine();
SortToLower(array2d);
PrintMatrix(array2d);
// Console.WriteLine();
// int[] arrangeElemToWane = ArrangeElemToWane(array2d);
// PrintMass(arrangeElemToWane);
// PrintMatrix(arrangeElemToWane);
// int[] matrixToArray =  MatrixToArray( arraay2d)

// int[] ArrangeElemToWane(int[,] array2d)
// {
//     int[] mass = new int[array2d.Length];
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int r = 0; r < array2d.GetLength(1) - i; r++)
//         {
//             if (mass[r] < mass[r + 1])
//             {
//                 int temp = mass[r];
//                 mass[r] = mass[r + 1];
//                 mass[r + 1] = temp;

//             }
//         }
//     }
//     return mass;
// }

// void PrintMass(int[] mass)

// {
//     for (int i = 0; i < 12; i++)
//     {
//         Console.Write("|");
//         for (int r = 0; r < mass.GetLength(1); r++)
//         {
//             Console.Write($"{mass[i],3} ");
//         }
//         Console.WriteLine("|");
//     }
// }

// int[] MatrixToArray(int[,] arraay2d)
// int[] array = new int[array2d.Length];
// // int count = 0;
// {
//     int[] array = new int[array2d.Length];
//     int count = 0;

//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {

//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             array[count++] = array2d[i, j];
//         }
//     }
//     return array;
// }
void SortToLower(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            for (int k = 0; k < array2d.GetLength(1) - 1; k++)
            {
                if (array2d[i, k] < array2d[i, k + 1])
                {
                    int temp = array2d[i, k + 1];
                    array2d[i, k + 1] = array2d[i, k];
                    array2d[i, k] = temp;
                }
            }
        }
    }
}






