//Jovann Contreras
//Date 10/18/2022
//Desc: I am asking the user some questions such as what is their name and what time they woke up today.



Console.Clear();
string playAgain = "yes";
int time = 0;
bool wokeUpTime = false;
while (playAgain == "yes")
{


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


    }

   

    Console.WriteLine("Would you like to try again? type in Yes to retry or No to quit");

    string playAgainInput = "";

    while (playAgainInput != "yes" || playAgainInput != "no")
    {
        playAgainInput = Console.ReadLine().ToLower();
        if (playAgainInput == playAgain)
        {
            break;
        }
        else if (playAgainInput == "no")
        {
            Console.WriteLine("Thanks for playing!");
            playAgain = playAgainInput;
            break;

        }
        else
        {
            Console.WriteLine("Invalid Input");
            playAgainInput = "invalid";
        }


    }

}