// программа, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
Console.WriteLine("Enter a number");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a number");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a number");
int number3 = int.Parse(Console.ReadLine());

Answer(number1, number2, number3);

void Answer(int a, int b, int c)
{
    if(a+b>c && a+c>b && b+c>a) Console.WriteLine("Существует треугольник с такими сторонами");
    else Console.WriteLine("Треугольника с такими сторонами не существут");
}