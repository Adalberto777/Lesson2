// Метод вычисления факториала
int FactorialMenod(int number)
{
    if(number == 1 || number ==0) return 1; // 1!=1 0!=1
    else return number * FactorialMenod(number - 1);
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"{number}! = {FactorialMenod(number)}");
