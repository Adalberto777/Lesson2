//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] GetArray(int size, int minValue, int maxValue) //функция GetArray с параметрами: размер, мин элемент, макс элемент создает массив 
{                                                    //заполненный случайными числами
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue + 1);
  }
  return result;
}

// void PrintArray(int[] array) // печать элнментов массива заполненного случайными числами
// {
//   Console.WriteLine("Вывод массива заполненного случайными числами: ");
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i] + "| ");
//   }
//   Console.WriteLine("");
// }

// void PrintAntiArray(int[] array) // метод вывода массива в обратном порядке
// {
//     int length = array.Length;
    
//     for (int i = length-1; i >=0; i--)
//     {
//         Console.Write(array[i] + "| ");
//     }
   
// }

void ReversArray(int[] antiarray) // метод вывода массива в обратном порядке
{    
    for (int i = 0; i < antiarray.Length/2; i++)
    {
        int temp = antiarray[i];
        antiarray[i] = antiarray[antiarray.Length - 1 - i];
        antiarray[antiarray.Length - 1 - i] = temp;
    }   
}

int[] array = GetArray(10, 1, 999); //вызываем функцию GetArray с параметрами: размер, мин элемент, макс элемент
Console.WriteLine(String.Join("|", array));


ReversArray(array);
Console.WriteLine();
Console.WriteLine(String.Join("|", array)); 


