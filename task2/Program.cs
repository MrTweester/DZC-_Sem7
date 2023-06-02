// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void FillMatrixWithRandomNumbers(int [,] matrix)
{
    Random rnd = new Random();
    for(int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 11);
        }
    }
}

void PrintMatrix (int [,] matrix)
{
    for(int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}" + "\t");
        }
    Console.WriteLine();
    }
}

int FindIndexNumberMatrix(int[,] matrix, int posm, int posn)
{
    int position = 0;
    for(int i=0; i < matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            if (matrix[i,j]==matrix[posm, posn])
            {
                position = matrix[i,j];
            }
        }
   
    Console.WriteLine();
    }
    return position;
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,n];

FillMatrixWithRandomNumbers(matrix);
PrintMatrix(matrix);

System.Console.Write("Введите индекс строки массива: ");
int posm = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите индекс столбца массива: ");
int posn = Convert.ToInt32(Console.ReadLine());

int pos = FindIndexNumberMatrix(matrix, posm, posn);
Console.Write($"Значение элемента позиции строки {posm} и столбца {posn} равно {pos}");