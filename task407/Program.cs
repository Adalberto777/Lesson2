// программа, которая будет преобразовывать десятичное число в требуемое
Console.WriteLine("Enter a decimal number");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a system number");
int system = int.Parse(Console.ReadLine());

string res = DecToNum(number, system);

Console.WriteLine($"{number}->{res}");

string DecToNum(int decNumber, int otherSystem)
{
string result = "";
string nums = "0123456789ABCDEF";
while (decNumber > 0)
{
int ost = decNumber / otherSystem;
result = nums[decNumber - otherSystem * ost] + result;
decNumber /= otherSystem;
}
return result;
}


