//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 

//Найдите сумму отрицательных и положительных элементов массива.

int[] GetArray(int size, int minValue, int maxValue) //функция GetArray с параметрами: размер, мин элемент, макс элемент создает массив 
{                                                    //заполненный случайными числами
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}

void PrintArray(int[] array) // печать элнментов массива заполненного случайными числами
{
  Console.WriteLine("Вывод массива заполненного случайными числами: ");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + "| ");
  }
  Console.WriteLine("");
}

int GetpositiveSum(int[] array) //функция функция, которая возвращает сумму положительных элементов массива
{
  
  int positiveSum = 0;
  
  foreach (int value in array)
  {
    positiveSum += value > 0 ? value : 0;
  }
  return positiveSum; 
}

int GetnegativeSumn(int[] array) //функция функция, которая возвращает сумму отрицательных элементов массива
{
  
  int negativeSum = 0;

  foreach (int value in array)
  {
    negativeSum += value < 0 ? value : 0;
  }
  return negativeSum;
}


int[] array = GetArray(12, -9, 9); //вызываем функцию GetArray с параметрами: размер, мин элемент, макс элемент
PrintArray(array);





Console.WriteLine($"сумма всех положительных элементов массива: {GetpositiveSum(array)}, сумма всех отрицательных элементов массива: {GetnegativeSumn(array)}");

