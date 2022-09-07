// программа, которая будет преобразовывать десятичное число в двоичное
Console.WriteLine("Enter a decimal number");
// int decimaNumber = int.Parse(Console.ReadLine());

// while(decimaNumber > 0)
// {
//     int temp = decimaNumber / 2;
//     int binaryNumber = decimaNumber - 2 * temp;
//     Console.Write(binaryNumber);
//     decimaNumber = temp;

// }

int number = int.Parse(Console.ReadLine());

string res1 = Convert.ToString(number, 2);
string res2 = DecToNum(number, 2);

Console.WriteLine($"{number}->{res1}");




// Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
string res = "";
string nums = "0123456789ABCDEF";
while (decNumber > 0)
{
int ost = decNumber / otherSystem;
res = nums[decNumber - otherSystem * ost] + res;
decNumber /= otherSystem;
}
return res;
}

