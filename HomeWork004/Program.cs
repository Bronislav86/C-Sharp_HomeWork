/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = a;
for (int i = 1; i < b; i++)
{
   result *= a;
}

Console.WriteLine(result);
*/

//----------------------------------------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumOfNumbers(int n)
// {
//     int sum = 0;
//     int ost = 0;
//     while (n > 0)
//     {
//         ost = n % 10;
//         sum += ost;
//         n = n / 10;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumOfNumbers(n));

//--------------------------------------------------------

// Задача 29: Напишите программу, которая принимает на вход длину массива
// и в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArray(array);
Console.WriteLine($"Ваш массив: [{String.Join(", ", array)}]");
