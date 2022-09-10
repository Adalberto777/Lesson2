//Задаем двумерный массив из случайных чисел размером m×n
Console.WriteLine("введите количество строк");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int m = int.Parse(Console.ReadLine());

int[,] GetMatrix(int lines, int columns, int minValue, int maxValue) //функция GetArray с параметрами: размер, мин элемент, макс элемент создает массив 
{                                                    //заполненный случайными числами
  int[,] result = new int[lines, columns];

  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
        result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}


void PrintMatrix (int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)  // matrix.GetLength(0) конструкция выдает количество строк или столбцов 
    {                                              // в зависимости 0 или 1 (0- строки, 1 столбцы)
        for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        Console.Write($"{matrix1[i, j]} ");
    }
    Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(n, m, 1, 9); //1-строки 2-столбцы 3-минимальное число 4-максимальное число
PrintMatrix(matrix);

  