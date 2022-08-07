// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
//453 -> 12
//45 -> 9

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int DigetSumm(int n)
{
    if (n == 0)
    {
        System.Console.WriteLine("Условие выхода сработало");
        return 0;

    }
    //System.Console.WriteLine( n);
    return DigetSumm(n / 10) + n % 10;

}
int number = Prompt("введите число ");
int result = DigetSumm(number);
System.Console.WriteLine(result);
