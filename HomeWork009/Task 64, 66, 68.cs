// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
string f(int n)
{
    if (n == 1)
        return " 1";
    return  $" " + n + f(n - 1);
}


Console.Clear();
Console.Write("Введитe Число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
*/

//------------------------------------------------------------------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int multiplication (int m, int n)
{
    if (m == n)
        return m; 
    return multiplication (m, n - 1) + n;
}


Console.Clear();
Console.Write("Введитe число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введитe число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(multiplication(m, n));
*/

//--------------------------------------------------------------------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int accerman (int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return accerman(m - 1, 1);
    else 
        return accerman(m - 1, accerman(m, n - 1)); 
}

Console.Clear();
Console.Write("Введитe число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введитe число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(accerman(m, n));