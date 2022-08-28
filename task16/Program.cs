Console.WriteLine("получаем на вход число N и выводит квадраты чисел от 1 до N");

Console.WriteLine("Enter a integer number");

int N = int.Parse(Console.ReadLine());
int i = 1;

while (i < N + 1)
{
    Console.Write($"{Math.Pow(i,2)}, ");
    i++;
}
