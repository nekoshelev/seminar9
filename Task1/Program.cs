// Задача 1: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке
// от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNatural(int n)
{
    if (n == 0)
    {
        System.Console.WriteLine("Условие выхода сработало");
        return;
    }

    System.Console.WriteLine("Идем вглубь " + n);
    PrintNatural(n - 1);
    System.Console.WriteLine("Выбираемся наверх " + n);
}

int n = 4;// Prompt("Введите натуральное число >");
PrintNatural(n);