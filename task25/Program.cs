// Дается число, необходимо выдать сумму всех чисел от 1 до a

int Metod(int a) 
{
    int i = 0;
    int sum = 0;

    while(i < a)
    {
        sum = sum + i;
        i++;
    }
    return sum;
}

Console.WriteLine("Enter a ");
int a = int.Parse(Console.ReadLine());

int res = Metod(a);
Console.WriteLine(res);
 