// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];

// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//         matrix[i, j] = Convert.ToInt32(new Random().Next(0, 11));
//         }
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//             Console.Write(matrix[i, j] + "\t  ");
//             Console.WriteLine();
//             }
//         }

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//         sum += matrix[i, j];
//         }
//         Console.Write($"Cреднее арифметическое значение элементов в стобце №{j+1} -> {sum / matrix.GetLength(1)} ");
//     }

//     if (m <= 0 || n <= 0) 
//     {
//         Console.Write($"Такого массива не существует");
//     }

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

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,n];

FillMatrixWithRandomNumbers(matrix);
PrintMatrix(matrix);

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    sum += matrix[i, j];
    }
        Console.WriteLine($"Cреднее арифметическое значение в стобце №{j+1} -> {Math.Round(sum / matrix.GetLength(1), 2)} ");
    }

    if (m <= 0 || n <= 0) 
    {
        Console.Write($"Такого массива не существует");
    }





