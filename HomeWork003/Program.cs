// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//       if (number < 10000 || number > 99999)
//       {
//         Console.WriteLine("Число не пятизначное");
//         return false;
//       }
//       else if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
//       {
//         return true;
//       }
//       else
//       {
//         return false;
//       }
//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 54345;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }

//-----------------------------------------------------------------
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// using System;

// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже
//     int[] pointA = {x1, x2, x3};
//     int[] pointB = {y1, y2, y3};
//     }

//     private static double DistanceBetweenPoints

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }

//-------------------произведение чисел от 1 до N-------------------

// void ProductNumbers(int n)
// {
//     int result = 1;
//     for(int i=1; i<=n; i++)
//         result *=i;
//         Console.WriteLine(result);          
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// ProductNumbers(n);


//-------------------------таблица кубов чисел------------------------

using System;

public class Answer
{
    static void ShowCube(int N)
    {
        // Введите свое решение ниже
        double result = 0;
        int i = 1;
        while (i <= N)
        {
            result = Math.Pow((i), 3);
            Console.WriteLine(result);
            i++;
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}