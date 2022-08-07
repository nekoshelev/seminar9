// Задайте значения M и N. Напишите программу, которая рекурсивно выведет
//все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNatural(int n, int m)
{
    if (n < m)
    {
        System.Console.WriteLine("Условие выхода сработало");
        return;
    }
    //System.Console.WriteLine( n);
    PrintNatural(n - 1, m);
    System.Console.Write($" {n}");
}
int n = 9;
int m = 2;
PrintNatural(n, m);
