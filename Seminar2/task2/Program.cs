// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: "); // по строчке 16, оно не должно быть больше 999999
int number = Convert.ToInt32(Console.ReadLine());
int centerNumber = 0; // для красивого вывода, можно обойтись (number)

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999999) // подгон под условия задачи (больше девяток, больше вводимое число)
    {
        centerNumber = number / 10;
    }
    centerNumber = number % 10;
    System.Console.WriteLine($"{number} -> {centerNumber}");
}