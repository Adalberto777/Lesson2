Console.WriteLine("получаем на вход координаты двух точек, выводим расстояние между ними");

Console.WriteLine("Enter a x1");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a y1");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a x2");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter a y2");
double y2 = Convert.ToDouble(Console.ReadLine());

double v = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
Console.WriteLine($"расстояние между точками - {v}");