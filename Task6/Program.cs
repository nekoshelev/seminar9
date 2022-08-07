// Задача 6: Проверка на простое число:
//N = 13 -> "Это простое число"
//N = 12 -> “Это не простое число”

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
bool DigetPrime(int n, int m)
{

    if (m == 1)
    {
        System.Console.WriteLine("Условие выхода сработало");
        return true;
    }

    return DigetPrime(n, m - 1) && (n % m > 0);

}
int number = Prompt("введите число ");
Console.WriteLine(DigetPrime(number, number - 1));