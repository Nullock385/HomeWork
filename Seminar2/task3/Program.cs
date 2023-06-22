// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру дня недели: ");
int DayWeek = Convert.ToInt32(Console.ReadLine());

if (DayWeek == 6 || DayWeek == 7)
{
    System.Console.WriteLine($"{DayWeek} -> да");
}
else if (DayWeek < 1 || DayWeek > 7) 
{
    System.Console.WriteLine("Введите корректную цифру дня недели");
}
else
{
    System.Console.WriteLine($"{DayWeek} -> нет");
}

