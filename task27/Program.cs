// Дается число, нужно посчитать произведение чисел от 1 до N

int HMD(int a) // функция
{
    int count = 1; //искомая величина
    int i = 1;    // счетчик до числа   
    while(i < a) // учловие остановки цикла
    {
        count = count * i; //умножаем на счетчик пока он не станет равен введенному числу
        i = i + 1; // увеличиваем четчик на 1 после каждого умножения
    }
    return count;
}

Console.WriteLine("Enter a ");
int a = int.Parse(Console.ReadLine());

int res = HMD(a);
Console.WriteLine(res);