//Jovann Contreras
//Date 10/18/2022
//Desc: I am asking the user some questions such as what is their name and what time they woke up today.



Console.Clear();
int time = 0;
bool wokeUpTime = false;
string playAgain = "yes";
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
    if (amOrpm == "am" || amOrpm == "pm")
    {
        Console.WriteLine($"Hello {userName} you woke up at {time}{amOrpm}");
    }
    else
    {
        Console.WriteLine("Not a valid pick type in Am or Pm");
    }
}
