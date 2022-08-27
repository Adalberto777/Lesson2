Console.WriteLine("Программа выводит случайное число от 10 до 99 и сообщает в нем большую цифру");

int number = new Random().Next(10,100);
Console.WriteLine($"Программа сгенерировала случайное число от 10 до 99: {number}");

int number1 = number / 10;
int number2 = number % 10;

if(number1 > number2)
{
    Console.WriteLine($"в числе {number} - {number1} больше {number2}");
}

else Console.WriteLine($"в числе {number} - {number2} больше {number1}");
