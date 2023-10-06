/*-//--------------Задача: Найти макисмальное и минимальное значение массива, найти разницу между
этими значениями и вывести массив и разницу на печать----------------------------*/

double FindMax(double[] array)
{     // Введите свое решение ниже
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{     // Введите свое решение ниже
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{// Введите свое решение ниже
    double diff = 0;
    double max = array[0];
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {     
        if (max > array[i]) max = array[i];
            else if (min < array[i]) min = array[i];
        diff = (max - min) * -1;
    }
    return diff;
}

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1000);
}

void PrintArray(double[] array)
{// Введите свое решение ниже
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{string.Join("\t", array[i])}\t");
    }
    Console.WriteLine();
}

Console.Clear();
// Console.WriteLine("Введите количество элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[] { 3.17, 8.94, 2.36, 5.72, 0.85 };
// InputArray(array);
PrintArray(array);
FindMax(array);
FindMin(array);
Console.WriteLine($"Максимальное знач: {FindMax(array)}, Минимальное знач: {FindMin(array)}");
CalcDifferenceBetweenMaxMin(array);
Console.WriteLine($"Разница между максимумом и минимумом: {CalcDifferenceBetweenMaxMin(array)}");