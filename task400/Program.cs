//Задайте двумерный массив из строк
string[,] table = new string[2, 5];

//string.Empty;
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 23 table[1, 3] table[1, 4]

table[1, 2] = "слово"; //образец вывода на экран строчного двумерного массива

for (int rows = 0; rows < 2; rows++)  
{
     for (int columns = 0; columns < 5; columns++)
     {
         Console.Write($" -{table[rows, columns]}");
     }
     Console.WriteLine();
}