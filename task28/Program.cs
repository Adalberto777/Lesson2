//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


void WriteMassiv(int[] massive) //метод который заполняет массив
{
    int lenght = massive.Length;
    int index = 0;
    while(index < lenght)
    {
        
        massive[index] = new Random().Next(0,2); // наполняем массив случайными цифрами от 0 до 1 (2-1 так работает Next)
        index++;
    }
}

void PrintMassiv(int[] massiv) // метод который выводит массив
{
    int lenght = massiv.Length;
    int index = 0;
    while(index < lenght)
    {
        Console.Write($"{massiv[index]}|");
        index++;        
    }
}

int[] array = new int[8]; //объявляем массив на 8 элементов

WriteMassiv(array);

Console.Write("|");

PrintMassiv(array);
