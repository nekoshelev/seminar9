// Задача 5: Определите, является ли число степенью двойки:
//N = 16 -> "Является степень двойки"
//N = 12 -> “Не является степенью двойки”

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool DigetPower2_1(int n)
{

    if (n == 1)
    {
        System.Console.WriteLine("Условие выхода сработало");
        return true;

    }

    return DigetPower2_1(n / 2) && (n % 2 == 0);

}
bool DigetPower2_2(int n)
{
    return ((n - 1) & n) == 0;
}
int number = Prompt("введите число ");
System.Console.WriteLine(DigetPower2_1(number));
System.Console.WriteLine(DigetPower2_2(number));