// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            // matr[i, j] = new Random().Next(1, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangePlaces(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int lastrow = matr.GetLength(0) - 1;
        int number = matr[0, j];
        matr[0, j] = matr[lastrow, j];
        matr[lastrow, j] = number;
    }
    return matr;
}
int [,] matrix = {
{1, 2 ,3},
{4, 5, 6},
{7, 8 , 9},
{10, 11 , 12}
};
PrintMatrix(matrix);
PrintMatrix(ChangePlaces(matrix));
// int [,] changedmatrix = ChangePlaces(matrix);
// Console.WriteLine(changedmatrix);