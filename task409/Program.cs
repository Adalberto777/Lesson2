// программа, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
Console.WriteLine("введите три числа через пробел");
string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); //считывает строку, когда видит пробел 
                                                                                    //отделяет выражение и записывает в массив строк
bool IsTriangle(int a, int b, int c) 
{ return (((a + b) > c) && ((a + c) > b) && ((b + c) > a)); }

Console.WriteLine(IsTriangle(int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2])));
