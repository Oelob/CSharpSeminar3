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
//     int fig_1 = (number / 10000) % 10;
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


// Количество цифр в числе через логарифм

// int x = 1245789;
// int digitCount = (int)Math.Log10(x) + 1;

// Console.Write(digitCount);


// количество цифр в числе через деление

int FiguresLong(int x)
{
    int count = 0;
    while (x > 0)
        {
           
            x = x / 10;
            count ++;
            
        }
    return count;
}

Console.WriteLine("число");
int x = Convert.ToInt32(Console.ReadLine());
int res = FiguresLong(x);
Console.Write(res);



