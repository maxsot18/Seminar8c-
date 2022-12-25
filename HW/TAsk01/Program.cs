// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по
//  убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintMAtrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[,] CreateMatrix(int m)
{

    int[,] matr = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {

            matr[i, j] = new Random().Next(1, 10);

        }
    }
    return matr;

}

int[,] StreamLine(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(1) - 1; l++)
            {
                if (arr[i, l] < arr[i, l + 1])
                {
                    int bigger = arr[i, l + 1];
                    arr[i, l + 1] = arr[i, l];
                    arr[i, l] = bigger;
                }
            }

        }
        

        
    }
    return arr;
}

int[,] matrix = CreateMatrix(5);
PrintMAtrix(matrix);
PrintMAtrix(StreamLine(matrix));
