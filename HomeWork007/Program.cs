//---------------------------Задача 1-------------------------------------------
/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n
(размерность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и
максимальную границы случайных чисел.

Также, задайте метод PrintArray, который выводил бы массив на экран.

Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j]
с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого
элемента матрицы. Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.
using System;
*/
/*
using System;

public class Answer {
  public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
      // Введите свое решение ниже
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
        }
    }
    return matrix;
  }

  public static void PrintArray(double[, ] matrix) {
      // Введите свое решение ниже
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
          for (int j = 0; j < matrix.GetLength(1); j++)
          {
            Console.Write($"{matrix[i, j]:F2} \t");
          }
          Console.WriteLine();
      }
   
  }

  // Не удаляйте и не меняйте метод Main! 
  public static void Main(string[] args) {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

        // Выберем случайные индексы трех элементов матрицы array
        int row1 = new Random().Next(0, m);
        int col1 = new Random().Next(0, n);
        int row2 = new Random().Next(0, m);
        int col2 = new Random().Next(0, n);
        int row3 = new Random().Next(0, m);
        int col3 = new Random().Next(0, n);

        // Проверяем, являются ли выбранные элементы дробными числами
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

        // Если два из трех элементов не являются дробными числами, то бросаем исключение
        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }
    } else {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;
      
      double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
}
*/

//----------------------------------Задача 2----------------------------------

// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся
// на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице.
// Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением.
// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной
// позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице.
// Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода
// FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на
// экран "The number in [{x}, {y}] is {значение}".

// using System.Numerics;

// void PrintArray(int[,] matrix)
// {
//   // Введите свое решение ниже
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] CreateIncreasingMatrix(int n, int m, int k)
// {
//   // Введите свое решение ниже
//   int[,] matrix = new int[n, m];
//   for (int i = 0; i < n; i++)
//   {
//     for (int j = 0; j < m; j++)
//     {
//       matrix[i, j] = new Random().Next(0, 100) + k;
//     }
//   }
//   return matrix;
// }

// int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
// {
//   //Введите свое решение ниже
//   int[] results = new int[2];
//   if (rowPosition < matrix.GetLength(0) && columnPosition < matrix.GetLength(1))
//   {
//     results[0] = matrix[i, j];
//     results[1] = 0;
//   }
//   else 
//   {
//     results[0] = 0;
//     results[1] = 0;
//   }
//   return results;
//   // int[] results = new int[2];
//   // for (int i = 0; i < matrix.GetLength(0); i++)
//   // {
//   //   for (int j = 0; j < matrix.GetLength(1); j++)
//   //   {
//   //     if (i == rowPosition && j == columnPosition)
//   //     {
//   //       results[0] = 1;
//   //       results[1] = 0;
//   //     }
//   //     else { results[0] = 0; }
//   //   }
//   // }
//   // return results;
// }

// void PrintCheckIfError(int[] results, int X, int Y)
// {
//   // Введите свое решение ниже
//   if (results[0] == 1)
//   {
//     Console.WriteLine($"The number in [{X}, {Y}] is {matrix[i, j]}");
//   }
//   else Console.WriteLine("There is no such index");

// }

// Console.Write("Введите число строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэф-т увеличения: ");
// int k = Convert.ToInt32(Console.ReadLine());
// //int[,] matrix = new int [n, m];
// CreateIncreasingMatrix(n, m, k);
// PrintArray(CreateIncreasingMatrix(n, m, k));
// Console.Write("Введите искомую строку: ");
// int rowPosition = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите искомый столбец: ");
// int columnPosition = Convert.ToInt32(Console.ReadLine());
// FindNumberByPosition(CreateIncreasingMatrix(n, m, k), rowPosition, columnPosition);
// Console.WriteLine(FindNumberByPosition(CreateIncreasingMatrix(n, m, k), rowPosition, columnPosition));
// PrintCheckIfError(results, X, Y);


// void InputMatrix(int[,] matrix, int k)
// {
//   int l = 1;
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i, j] = l;
//       l += k;
//     }
//     Console.WriteLine();
//   }
// }

// int ReleaseMatrix(int[,] matrix, int x, int y)
// {
//   int[] results = new int[2];
//   int count = results.Length;
//   results[1] = 0;
//   for (int l = 0; l < count; l++)
//   {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
        
//           results[0] = matrix [i, j];
        
//         else
        
//           results[0] = 0;      
//       }
//     }
//   }
//   return results[0];
// }



// void PrintMatrix(int [,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       Console.Write($"{matr[i,j]} \t");
//     }
//     Console.WriteLine();
//   }
// }

// void PrintCheckIfError (int[] results, int x, int y)
//     {
//       // Введите свое решение ниже
//       for (int i = 0; i < results.Length; i++)
//       {
//         if (results[0] != 0)  Console.WriteLine($"The number in [{x}, {y}] is {result[x, y]}");
//         else  Console.WriteLine("There is no such index");     
//       }
//     }

// Console.Clear();
// Console.Write("Введитe размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // 4 3
// int[,] matrix = new int[size[0], size[1]];
// Console.Write("Введитe k: ");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введитe Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введитe Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// InputMatrix(matrix, k);
// PrintMatrix(matrix);
// ReleaseMatrix(matrix, x, y);
// PrintCheckIfError (results, x, y);


//-------------Задача 3--------------------------------------------------------------------------

using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
      }    

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
      int[,] result = new int[n, m];
      int l = 1;
      for (int i = 0; i < result.GetLength(0); i++)
      {
        for (int j = 0; j < result.GetLength(1); j++)
        {
          result[i, j] = l;
          l += k;
        }
        Console.WriteLine();
      }
      return result;
    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
      Console.WriteLine("The averages in columns are:");
      for (int i = 0; i < list.Length; i++)
    {
      string result = string.Format("{0:f}", list[i]);
      Console.Write($"{result}\t");
    }

    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
      double[] result = new double [matrix.GetLength(1)];
      double averageValue = 0;
      int l = 0;
      for (int j = 0; j < matrix.GetLength(1); j++)
      {               
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          while (i < matrix.GetLength(0))
          {
            averageValue += matrix[i, j];
            i++;
          }
          averageValue /= matrix.GetLength(0);
          result[l] = averageValue;
          averageValue = 0;
          l++;
        }
      }
      return result;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 4;
           m = 5;
           k = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}

/// попробовать заполнить матрицу через NextDouble!---------------