// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int m = Prompt("Введите значение M > ");
int n = Prompt("Введите значение N > ");
Console.WriteLine($"A({m}, {n}) = {akman(m, n)}");

int akman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return akman(m - 1, 1);
    else
        return akman(m - 1, akman(m, n - 1));
}