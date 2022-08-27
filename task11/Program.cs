Console.WriteLine("получаем на вход два числа и проверяем является кто нибудь из них квадратом другого");

Console.WriteLine("Enter a first integer number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a second integer number");
int number2 = int.Parse(Console.ReadLine());

if(number1 ==  number2 * number2) Console.WriteLine($"{number1} является квадратом {number2}");
if(number2 ==  number1 * number1) Console.WriteLine($"{number2} является квадратом {number1}");
else Console.WriteLine($"{number1} и {number2} не являются квадратами друг друга");

