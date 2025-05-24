
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODO's");
Console.WriteLine("[A]add a TODOs");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

string[] validChoices = { "S", "A", "R", "E" };
while (!validChoices.Contains(userChoice?.ToUpper()))
{
    Console.WriteLine("Invalid choice, please insert your choice");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODO's");
    Console.WriteLine("[A]add a TODOs");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    userChoice = Console.ReadLine();
}

switch (userChoice?.ToUpper())
{
    case "S":
     PrintSelectedOption("See all TODOs");
     break;
    case "A":
     PrintSelectedOption("Add a TODO");
     break;
    case "R":
     PrintSelectedOption("Remove a TODO");
     break;
    case "E":
     PrintSelectedOption("I'm about to leave the program!");
     Environment.Exit(0);
     break;
}




void PrintSelectedOption(string selectedOption)
{
    System.Console.WriteLine("Selected option: " + selectedOption);
}



Console.ReadKey();