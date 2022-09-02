//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


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

string FindX(int[] array, int x) // печать элнментов массива заполненного случайными числами
{
  int f = 0;
  foreach (int value in array)
  {
    if(value == x) return "число есть";
  } 
  return "числа нет";
}

int[] array = GetArray(12, -9, 9); //вызываем функцию GetArray с параметрами: размер, мин элемент, макс элемент
PrintArray(array);

Console.WriteLine("Enter a x ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine(FindX(array, x));
