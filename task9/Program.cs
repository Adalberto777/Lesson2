Console.WriteLine("Программа создает случайное двузначное число от 10 до 99 и определяет кратность второго первому");

int number = new Random().Next(10,100);
Console.WriteLine($"Программа сгенерировала случайное число от 100 до 999: {number}");

int number1 = number / 10;
int number2 = number % 10;

if(number2 % number1 ==0)
Console.WriteLine($"{number2} кратно {number1}");

else Console.WriteLine($"остаток от деления {number2} на {number1} = {number2 % number1}");