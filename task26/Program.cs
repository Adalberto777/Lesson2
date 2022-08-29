// Дается число, нужно посчитать количество цифр в числе

int Metod(int a) 
{
    int count = 0;
    int dig = a;
    


    while(dig > 0)
    {
        dig = dig / 10;
        count = count + 1;
    }
    return count;
}

Console.WriteLine("Enter a ");
int a = int.Parse(Console.ReadLine());

int res = Metod(a);
Console.WriteLine(res);