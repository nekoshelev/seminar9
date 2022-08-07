﻿// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}


void PrintNatural(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0 & m != 0)
        {
            System.Console.Write($" {m}");
        }
        PrintNatural(m + 1, n);
    }
    return;
}
int m = Prompt("Введите значение (От) M > ");
int n = Prompt("Введите значение (До) N > ");
System.Console.WriteLine($"Чётные натуральные числа в промежутке от {m} до {n}:");
PrintNatural(m, n);