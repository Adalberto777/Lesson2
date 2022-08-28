Console.WriteLine("получаем на вход число N и выводит квадраты чисел от 1 до N");

Console.WriteLine("Enter a integer number");

int N = int.Parse(Console.ReadLine());

Console.Write(String.Join(" ", Enumerable.Range(1,N).Select(N=>N*N)));
