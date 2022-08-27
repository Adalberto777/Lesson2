Console.WriteLine("получаем на вход число и проверяем кратно ли оно одновременно 7 и 23");

Console.WriteLine("Enter a integer number");
int number = int.Parse(Console.ReadLine());

if(number % 7 ==0 && number % 23 ==0) Console.WriteLine($"{number} кратно 7 и 23");

else Console.WriteLine($"{number} не кратно одновременно 7 и 23");