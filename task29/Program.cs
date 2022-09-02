//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

void WriteMassiv(int[] massive) //метод который заполняет массив
{
    int lenght = massive.Length;
    
    for(int i = 0; i < lenght; i++)
    {
        massive[i] = new Random().Next(-9,10); // наполняем массив случайными цифрами
    }
}

void PrintMassiv(int[] massive) // метод который выводит массив
{
    int lenght = massive.Length;
    
    for(int i = 0; i < lenght; i++)
    {
        Console.Write($"{massive[i]}|");
    }
}

int PositiveSumMassive(int[] massive) // метод который выводит сумму положительных чисел массива
{
    int lenght = massive.Length;
    int positive = 0;
    
    for(int i = 0; i < lenght; i++)
    {
        if(massive[i] > 0) positive = positive + massive[i];        
    }
    return positive;
}

int NegativeSumMassive(int[] massive) // метод который выводит сумму отрицательных чисел массива
{
    int lenght = massive.Length;
    int negative = 0;

    for(int i = 0; i < lenght; i++)
    { 
        if(massive[i] < 0) negative = negative + massive[i];
    }
    return negative;
}


int[] massive = new int[12]; //объявляем массив 
WriteMassiv(massive);

Console.Write("|");

PrintMassiv(massive);

Console.WriteLine();
Console.WriteLine($"сумма всех положительных элементов массива: {PositiveSumMassive(massive)}");
Console.WriteLine($"сумма всех отрицательных элементов массива: {NegativeSumMassive(massive)}");