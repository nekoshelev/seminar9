// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8


int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int DigetPower(int n, int m)
{
    if (m == 0)
    {
        System.Console.WriteLine("Условие выхода сработало");
        return 1;

    }
    //System.Console.WriteLine( n);
    return DigetPower(n, m - 1) * n;

}
int number1 = Prompt("введите число1 ");
int number2 = Prompt("введите число2 ");
int result = DigetPower(number1, number2);
System.Console.WriteLine(result);