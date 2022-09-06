// Два руга идут на встречу друг другу, при этом между ними бегает собака первого руга, 
// программа считает сколько раз собака пробежит от одного друга к ругому

Console.WriteLine("Enter speed the first frend (km/h)");
double firstFriendSpeed = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter speed the second frend (km/h)");
double secondFriendSpeed = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter speed the dog (km/h)");
double dogSpeed = double.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the distance (km)");
double distance = double.Parse(Console.ReadLine()!);

double time = 0;
double stopDistance = 0.001;
string dogDirect = "toSecondFriend";
int count = 0;

while (distance > stopDistance)
{
    if(dogDirect == "toSecondFriend")
    {
        time = distance/(dogSpeed + secondFriendSpeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        dogDirect = "toFirstFriend";        
    }
    
    if(dogDirect == "toFirstFriend")
    {
        time = distance/(dogSpeed + firstFriendSpeed);
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        dogDirect = "toSecondFriend";        
    }
    count = count + 1;
}

Console.WriteLine();
Console.WriteLine($"пока друзья не встретятся, собака пробежит между ними {count} раз");
