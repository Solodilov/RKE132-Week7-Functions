Console.WriteLine("Are you coming or leaving? (in/out");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    Prinhello();
}
else
{
    PrintGoodbye();
}

static void Prinhello() //function or method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later, aligator!");
}
