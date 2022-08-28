Console.WriteLine("получаем на вход поскость в которой находится точка, выводим диапазон координат в которым могут быть равны х и у");

Console.WriteLine("Enter a number from 1 to 4");
int x = Convert.ToInt32(Console.ReadLine());

//if(x == 1) Console.WriteLine("x от +1 до +бесконечности, у от +1 до +бесконечности ");
//if(x == 2) Console.WriteLine("x от -1 до -бесконечности, у от +1 до +бесконечности ");
//if(x == 3) Console.WriteLine("x от -1 до -бесконечности, у от 1 до -бесконечности ");
//if(x == 4) Console.WriteLine("x от +1 до +бесконечности, у от -1 до -бесконечности ");

switch (x)
{
  case 1:
  {
      Console.WriteLine("x от +1 до +бесконечности, у от +1 до +бесконечности ");
      break;
  }
   case 2:
  {
      Console.WriteLine("x от -1 до -бесконечности, у от +1 до +бесконечности ");
      break;
  }
  case 3:
  {
      Console.WriteLine("x от -1 до -бесконечности, у от 1 до -бесконечности ");
      break;
  }
  case 4:
  {
      Console.WriteLine("x от +1 до +бесконечности, у от -1 до -бесконечности ");
      break;
  }
}