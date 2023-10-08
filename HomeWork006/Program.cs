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

// Console.Clear();
// Console.WriteLine("Введите нескольки чисел: ");
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

// int PositivNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > 0) count ++;
//     return count;
// }

// PositivNumber(array);
// Console.WriteLine(PositivNumber(array));

//--------------------------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1
// y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// k1*x - k2*x = b1 - b2
// x = (k1+k2)/b1 - b2