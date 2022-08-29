string Metod4(int count, string text) //получает на вход количество раз которое надо повторить текст и выполняет
{
    string result = string.Empty;//string.Empty аналогично "" т.е. в начале строка пустая (обязательно при создании переменное строки туда что то ложить)

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10,"ololo");
Console.WriteLine(res);
 