//---------------------------ЗАДАЧА из Автотеста---------------------------------------------
// double Length(int[] pointA, int[] pointB)
// {
//     // Введите свое решение ниже
//     double result = 0;
//     double value = 0;
//     for (int i = 0; i < pointA.Length; i++)
//     {
//         for (int j = 0; j < pointB.Length; j++)
//         {
//             value = Math.Pow((pointB[j] - pointA[i]), 2);          
//         }
//         result += value;
//     }
//     return result;
// }

// int[] pointA = {3, 6, 8};
// int[] pointB = {2, 1, -7};
// Length(pointA, pointB);
// Console.WriteLine(Length(pointA, pointB));

//-------второй способ----------------
/*
double Length(int[] pointA, int[] pointB)
{
    // Введите свое решение ниже
    int i = 0;
    int j = 0;
    double result = Math.Sqrt(Math.Pow((pointB[j] - pointA[i]), 2) + Math.Pow((pointB[j+1] - pointA[i+1]), 2)
            + Math.Pow((pointB[j+2] - pointA[i+2]), 2));          
    return result;
}

int[] pointA = {3, 6, 8};
int[] pointB = {2, 1, -7};
Length(pointA, pointB);
Console.WriteLine(Length(pointA, pointB));
*/

//---------------------------------------------------------------------------------------------

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// using System.Collections;
// using System.Security.Principal;

// int Prompt(string message) //считывает число из консоли
// {
//     System.Console.Write(message); //вывести сообщеине
//     string value = Console.ReadLine(); //считывает из консоли строку
//     int result = Convert.ToInt32(value); // преобразует строку в целое число
//     return result;
// }

// int [] InputArray (int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = Prompt($"Ведите {i + 1}-й элемент ");
//         }
//         return array;
// }

// int PositivNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0) count ++;
//     return count;
// }

// void PrintArray (int[] arr)
// {
//     for (int i =  0; i < arr.Length; i++)
//     {
//         Console.WriteLine($"a[{i}] = {arr[i]}");
//     }
// }


// Console.Clear();
// int length = Prompt("Введите количество элементов >");
// int[] array;
// array = InputArray(length);
// PrintArray(array);
// PositivNumber(array);
// Console.WriteLine($"Количество чисел больше 0: {PositivNumber(array)}");

//--------------------------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1
// y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// k1*x - k2*x = b2 - b1
// x = (b2 - b1) / (k1-k2)
// y = k1 * x + b1


//----------------------------I вариант-----------------------------------------------
/*
void IntersectionPoint (double b1, double k1, double b2, double k2, double x, double y)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"({x}; {y})");
}

Console.Clear();
Console.WriteLine("Введите координату b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;
IntersectionPoint(b1, k1, b2, k2, x, y);
*/
//------------------II вариант--------------------------------

// Console.Clear();
// Console.WriteLine("Введите координату b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = (k2 * x) + b2;

// Console.WriteLine($"({x}; {y})");
