// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 1 | 3 4
// 3 2 1 | 3 3
// _ _ _ | 1 1
// Результирующая матрица будет:
// 19 21
// 16 19

int[,] CreateMatrix(int m, int n)
{

    int[,] matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            matr[i, j] = new Random().Next(1, 10);

        }
    }
    return matr;

}

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
void ProductOfMatrix(int[,] arr, int[,] arr2, int[,] arr3)
{
    
    for (int i = 0; i < arr3.GetLength(0); i++)
    {

        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
               sum += arr[i, k] * arr2[k, j];
            }
            arr3[i,j] = sum;
                
        }
    }
    
}

int[,] matrix = CreateMatrix(2, 3);
int[,] matrix2 = CreateMatrix(3, 2);
int[,] productofMatrix = CreateMatrix(2, 2);
PrintMAtrix(matrix);
PrintMAtrix(matrix2);
ProductOfMatrix(matrix, matrix2, productofMatrix);
Console.WriteLine("Product of matrix = ");
PrintMAtrix(productofMatrix);