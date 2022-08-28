Console.WriteLine("получаем на вход координаты на вход х и у, причем х и у != 0 и показываем в какой плоскщсти будет точка");

Console.WriteLine("Enter a x ");
int x = int.Parse(Console.ReadLine()); //Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a y ");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0) Console.WriteLine("в плоскости 1");
if(x > 0 && y < 0) Console.WriteLine("в плоскости 4");
if(x < 0 && y > 0) Console.WriteLine("в плоскости 2");
if(x < 0 && y < 0) Console.WriteLine("в плоскости 3");
