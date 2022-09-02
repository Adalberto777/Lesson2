//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Положительные замените на отрицательные и наоборот


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

void PrintNegativeArray(int[] array) // печать элнментов массива заполненного случайными числами
{
  Console.WriteLine("Вывод массива, с элементами обратыми первоначальному: ");
  foreach (int value in array)
  {
    Console.Write($"{value * -1}| ");
  }
  Console.WriteLine("");
}


int[] array = GetArray(12, -9, 9); //вызываем функцию GetArray с параметрами: размер, мин элемент, макс элемент
PrintArray(array);

Console.WriteLine();
PrintNegativeArray(array);

