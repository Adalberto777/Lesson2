// Дан текст. В тексте необходимо заменить все пробелы черточками, маленькие буквы "к" заменить "К", а большие буквы "С" заменить "с"
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//       i =  012345 - index's
//s[3] = r
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int lenght = text.Length;
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ','|');
string newText1 = Replace(newText, 'к','К');
string newText2 = Replace(newText1, 'С','с');
Console.WriteLine(newText2); 