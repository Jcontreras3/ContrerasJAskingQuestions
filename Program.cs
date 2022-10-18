//Jovann Contreras
//Date 10/18/2022
//Desc: I am asking the user some questions such as what is their name and what time they woke up today.



Console.Clear();
int time = 0;
bool wokeUpTime = false;
Console.WriteLine("Welcome to Challenge 3 Asking Questions");
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
while (string.IsNullOrEmpty(userName))
{

    Console.WriteLine("No name was entered");
}

Console.WriteLine($"Name: {userName}");


while (!wokeUpTime)
{
    Console.WriteLine("What time did you wake up today?");
    wokeUpTime = Int32.TryParse(Console.ReadLine(), out time);
    if (wokeUpTime)
    {
        Console.WriteLine($"Time: {time}");
    }
    else
    {
        Console.WriteLine("Not a specific time");
    }

    Console.WriteLine("Was it Am or Pm?");
    string amOrpm = Console.ReadLine().ToLower();
    if (amOrpm == "am")
    {
        Console.WriteLine($"Hello {userName} you woke up at {time}am");
    }

    else if (amOrpm == "pm")
    {
        Console.WriteLine($"Hello {userName} you woke up at {time}pm");
    }
    else
    {
        Console.WriteLine("Not a valid pick please enter in am or pm");
        amOrpm = Console.ReadLine().ToLower();
    }
}
