// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7 min = 5
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (a > b)
{
    max = a;
    min = b;
}
else            // (сам себе пишу пометку) здесь не нужно писать условие в скобках, т.к. else и так бозначает действие если условие if не соблюдается (false)
{
    max = b;
    min = a;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
*/

//--------------------------------------------------------------------------------------------------

//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
/*
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.Write("max = ");
Console.WriteLine(max);
*/

//------------------------------------------------------------------------------------------------

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
/*
Console.WriteLine("Для опредлениея является ли Ваше число четным введите целое число: ");
Console.WriteLine();
int a = Convert.ToInt32(Console.ReadLine());

if (0 == a % 2)
{
    Console.WriteLine();
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Нет");
}
*/

//-------------------------------------------------------------------------------------

// Задача 8: Напишите программу, которая на вход принимает число (N), а на
// выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}

