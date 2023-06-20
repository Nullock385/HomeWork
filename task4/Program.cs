// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int check = 1;
while (number >= check)
{
    if (check % 2 == 0)
        System.Console.Write($" {check},");
    check++;
}


