//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
Console.WriteLine("Введите число N");
int n2 = int.Parse(Console.ReadLine());
int n1 = 1;

string PrintNumbers(int start, int end)
{
if (start == end) return start.ToString();
return (start + " " + PrintNumbers(start + 1, end));
}

 Console.Write(PrintNumbers(n1, n2));

