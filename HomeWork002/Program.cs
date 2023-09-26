// Задnvetача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.WriteLine("Введите трехзначное число ");
// int a = Convert.ToInt32(Console.ReadLine());

// int a1 = a % 100;
// int a2 = a1 / 10;
// Console.WriteLine(a2);

//-----------------------------------------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();
// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// int a1 = a / 100;
// int a2 = a % 10;

// if (a1 > 0)
//     Console.WriteLine(a2);
// else
//     Console.WriteLine("Третьей цифры нет");

//-------------------------------------------------------------------------------------------

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());

//Первый способ

//     if (n < 1 && n > 7)
//         Console.WriteLine("Вы ввели некорректное число!");
//     else if (n == 1)
//         Console.WriteLine("Нет");
//     else if (n == 2)
//         Console.WriteLine("Нет");
//     else if (n == 3)
//         Console.WriteLine("Нет");
//     else if (n == 4)
//         Console.WriteLine("Нет");
//     else if (n == 5)
//         Console.WriteLine("Нет");
//     else if (n == 6)
//         Console.WriteLine("Да");
//     else if (n == 7)
//         Console.WriteLine("Да");

// Второй способ

string f(int n)
{
    if (n < 1 || n > 7)
        return "Вы ввели некорректное число!";
    else if (n == 1)
         return "Нет";
    else if (n == 2)
         return "Нет";
    else if (n == 3)
         return "Нет";
    else if (n == 4)
         return "Нет";
    else if (n == 5)
         return "Нет";
    else if (n == 6)
         return "Да";
         return"Да";
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"- {f(n)}"); 