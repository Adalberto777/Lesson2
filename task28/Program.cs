//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void WriteMassiv(int[] massive) //метод который заполняет массив
{
    int lenght = massive.Length;
    
    for(int i = 0; i < lenght; i++)
    {
        massive[i] = new Random().Next(0,2); // наполняем массив случайными цифрами от 0 до 1 (2-1 так работает Next)
    }
}

void PrintMassiv(int[] massiv) // метод который выводит массив
{
    int lenght = massiv.Length;
    
    for(int i = 0; i < lenght; i++)
    {
        Console.Write($"{massiv[i]}|");
    }
}

int[] array = new int[8]; //объявляем массив на 8 элементов

WriteMassiv(array);

Console.Write("|");

PrintMassiv(array);