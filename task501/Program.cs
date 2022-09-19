//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} -> {SumNumbers(number)}");

int SumNumbers(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return (number % 10 + SumNumbers(number / 10));
}

