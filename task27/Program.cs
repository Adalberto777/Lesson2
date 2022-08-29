// Дается число, нужно посчитать произведение чисел от 1 до N

int HMD(int a) 
{
    int count = 1;
    int i = 1;    
    while(i < a)
    {
        count = count * i;
        i = i + 1;
    }
    return count;
}

Console.WriteLine("Enter a ");
int a = int.Parse(Console.ReadLine());

int res = HMD(a);
Console.WriteLine(res);