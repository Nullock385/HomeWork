// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine("Ваше число палиндром");
    }
    else
    {
        System.Console.WriteLine("Ваше число не палиндром");
    }
}
else
{
    System.Console.WriteLine($"Число {number} не является пятизначным");
}