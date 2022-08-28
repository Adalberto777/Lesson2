Console.WriteLine("получаем на вход число N и выводит квадраты чисел от 1 до N");

Console.WriteLine("Enter a integer number");

int N = int.Parse(Console.ReadLine());
String result = "";

for(int i = 1; i < N + 1; i++)
{
    double res = Math.Pow(i,2);
    result = result + res + " / ";
}

Console.WriteLine(result);
