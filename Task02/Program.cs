// Задача 2: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.




int[,] CreateMatrix(int m)
{
        
    int[,] matr = new int [m, m]; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {

            matr[i, j] = new Random().Next(1, 10);
            
        }
    }
    return matr;   

}
void PrintMAtrix(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    
}

int[,] TransPon(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i; j < matr.GetLength(1); j++)
        {
            int number = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j , i] = number;
        }
    }
    return matr;
}
int[,] array = CreateMatrix(4);
PrintMAtrix(array);
PrintMAtrix(TransPon(array));
