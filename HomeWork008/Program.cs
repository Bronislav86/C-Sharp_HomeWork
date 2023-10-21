//-----------------------------------Задача 1-----------------------------------------------
/*
using System;

public class Answer
{
    public static void PrintMatrix(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
    }


    public static void SortRowsDescending(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                for (int colSort = 0; colSort < matrix.GetLength(1) - 1; colSort++)
                {
                    if (matrix[row, colSort] < matrix[row, colSort + 1])
                    {
                        int temp = matrix[row, colSort + 1];
                        matrix[row, colSort + 1] = matrix[row, colSort];
                        matrix[row, colSort] = temp;
                    }
                }
            }
        }
    }


    // Не удаляйте и не меняйте метод Main!
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,] {
                {9, 1, 7},
                {1, 2, 3},
                {4, 5, 6}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                if (elements.Length != matrix.GetLength(1))
                {
                    Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
                    return;
                }
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        SortRowsDescending(matrix);

        Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
        PrintMatrix(matrix);
    }
}
*/

//-----------------------------------------Задача 2------------------------------------------------------------

// using System;

// public class Answer
// {
//     public static int SumOfRow(int[,] matrix, int row)
//     {
//         // Введите свое решение ниже
//         int summ = 0;
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 summ += matrix[row, j];
//             }
//         return summ;
//     }

//     public static int[] MinimumSumRow(int[,] matrix)
//     {
//         // Введите свое решение ниже
//         int[] minimumSumRow = new int[3];
//         int min = SumOfRow(matrix, 0);
//         minimumSumRow[0] = 0;
//         minimumSumRow[1] = min;
//         for (int row = 1; row < matrix.GetLength(0); row++)
//         {
//             int sumRow = SumOfRow(matrix, row);
//             if (sumRow < min || sumRow == min)
//             {
//                 min = sumRow;
//                 minimumSumRow[0] = row;
//                 minimumSumRow[1] = min;
//             }
//         }
//         return minimumSumRow;
//     }

//     // Не удаляйте и не меняйте метод Main!
//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             // Если аргументы не переданы, используем матрицу по умолчанию

//             matrix = new int[,]
//             {
//                 { 9, 5, 3 },
//                 { 9, 6, 2 },
//                 { 7, 6, 5 }
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }

//         int[] minSumRow = MinimumSumRow(matrix);

//         Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
//         Console.WriteLine($"\nСумма элементов в строке {minSumRow[0] + 1}: {minSumRow[1]}");
//     }
// }
// найти способ выводить оба результата, если есть одинаковая сумма в нескольких строках!!!!!!!!!!!!!!

//------------------------------------Задача 3--------------------------------------------------------------------------

using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        //new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        if (matrixA.GetLength(0) == matrixB.GetLength(1))
        {
            int[,] matrix = MatrixMultiplication(matrixA, matrixB);
            PrintMatrix(matrix);
        }
        else
            Console.WriteLine("It is impossible to multiply.");
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                for (int inner = 0; inner < matrixB.GetLength(0); inner++)
                {
                    result [row, col] += matrixA[row, inner] * matrixB[inner, col];
                }
            }
        }
        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    { // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    // Не удаляйте и не меняйте метод Main!
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                { 1, 2 },
                { 3, 4 }
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB =
        {
            { 5, 6 },
            { 7, 8 }
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}
