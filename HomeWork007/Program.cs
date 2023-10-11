//---------------------------Задача 1-------------------------------------------
/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n
(размерность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

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
            matrix[i, j] = new Random().NextDouble() * (maxLimitRandom -                                  minLimitRandom) + minLimitRandom;
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

void PrintArray (int [,] matrix)
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

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
  // Введите свое решение ниже
  int[,] matrix = new int[n, m];
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < m; j++)
    {
      matrix[i, j] = new Random().Next(0, 10);
      matrix [i, j] += k;
    }
  }
  return matrix;
}

Console.Write("Введите число строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэф-т увеличения: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [n, m];
CreateIncreasingMatrix(n, m, k);
PrintArray(matrix);