Console.WriteLine("Программа создает случайное число от 100 до 999 и удаляем цифру по середине");

int number = new Random().Next(100,1000);
Console.WriteLine($"Программа сгенерировала случайное число от 100 до 999: {number}");

int number1 = number / 100;
int number2 = number % 10;

//Console.WriteLine($"удаляем число по середине, получаем: {number1}{number2}");
Console.WriteLine($"удаляем число по середине, получаем: {number1 * 10 + number2}");
