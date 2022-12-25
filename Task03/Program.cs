// Задача 3: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь 
// содержит информацию о том, сколько раз 
// встречается элемент входных данных. 
// Значения элементов массива 0..9
//  { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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
void PrintMAtrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
int[] Dictionary(int[,] array)
{
    int[] dict = new int[10];
    foreach (int item in array)
    {
        dict[item]++;
    }
    
    return dict;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[,] array = CreateMatrix(4);
PrintMAtrix(array);
PrintArray(Dictionary(array));
