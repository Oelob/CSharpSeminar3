using System;
using System.Linq;
using System.Text;
Console.Clear();

/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// string Palindrome(int number)
// {
//     string result;
//     int fig_1 = (number / 10000);
//     int fig_2 = (number / 1000) % 10;
//     int fig_4 = (number / 10) % 10;
//     int fig_5 = number % 10;

//     if (fig_1 == fig_5 && fig_2 == fig_4)
//     {
//         result = "Данное число палиндром";
//     }
//     else
//     {
//         result = "Данное число не палиндром";
//     }
//     return result;
// }

// Console.WriteLine("Введите пятизначное число: ");
// int figure = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// string res = Palindrome(figure);
// Console.Write(res);

/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/



double GetDistance(int coord1_1, int coord1_2,int coord1_3,int coord2_1,int coord2_2,int coord2_3)
{
   
    double result = Math.Sqrt(Math.Pow((coord2_1 - coord1_1), 2) + Math.Pow((coord2_2 - coord1_2), 2) + Math.Pow((coord2_3 - coord1_3), 2));
    return result;

}

Console.WriteLine("Kоординаты точки А \n Введите X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kоординаты точки B \n Введите X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.Write($"Расстояние между точками А и В " + distance);
