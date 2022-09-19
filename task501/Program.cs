//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} -> {SumNumbers(number)}");

int SumNumbers(int number1)
{
    if (number1 == 0)
    {
        return 0;
    }
    return (number1 % 10 + SumNumbers(number1 / 10));
}

