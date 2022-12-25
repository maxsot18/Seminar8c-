// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void MinSumElementsOnRows(int[,] array)
{
    int sum = 0;
    int minsum = 1000;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minsum > sum)
        {
            minsum = sum;
        }
        
    }
    Console.WriteLine($"Minimal sum of elements on rows {minsum}");
    
}



int[,] matrix = CreateMatrix(8, 5);
PrintMAtrix(matrix);
MinSumElementsOnRows(matrix);