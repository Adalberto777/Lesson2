// 1 группа методов
void Metod1()
{
    Console.WriteLine("autor this program: Tliashev Albert Ildusovich");
}
Metod1(); // вызов метода 

// 2 группа методов

void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2("text of message"); // вызов метода

void Metod21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
//Metod21("text of message", 4); вызов метода и через запятую указываем сколько раз
Metod21(count: 4, msg: "new text");  //алтернативный вариант, при конкретном прописывании элементов, порядок их указания при вызове метода не важен

// 3 группа методов

int Metod3() //ничего на вход не принимает, но возвращает текущий год (можно случайное число)
{
    return DateTime.Now.Year;
}
int year = Metod3();
 Console.WriteLine(year);

// 4 группа методов

string Metod4(int count, string text) //получает на вход количество раз которое надо повторить текст и выполняет
{
    int i = 0;
    string result = string.Empty;//string.Empty аналогично "" т.е. в начале строка пустая (обязательно при создании переменное строки туда что то ложить)

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10,"ololo");
Console.WriteLine(res);
 