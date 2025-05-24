
// Lista che contiene tutti i TODO inseriti dall'utente
List<string> todos = new List<string>();
// array delle lettere valide per le opzioni della TODO
string[] validChoices = { "S", "A", "R", "E" };
// Variabile per memorizzare la scelta dell'utente nel menu
string userChoice;


do
{
    PrintAllAvailableOptions();
    userChoice = Console.ReadLine();

    while (!validChoices.Contains(userChoice?.ToUpper()))
    {
        Console.WriteLine("Invalid choice, please insert your choice");
        PrintAllAvailableOptions();
        userChoice = Console.ReadLine();
    }

    switch (userChoice?.ToUpper())
    {
        case "S":
            PrintSelectedOption("See all TODOs");
            PrintAllTodo(todos);
            break;
        case "A":
            PrintSelectedOption("Add a TODO");
            break;
        case "R":
            PrintSelectedOption("Remove a TODO");
            break;
        case "E":
            PrintSelectedOption("I'm about to leave the program!");
            break;
    }
} while (userChoice?.ToUpper() != "E");




void PrintSelectedOption(string selectedOption)
{
    System.Console.WriteLine("Selected option: " + selectedOption);
}

void PrintAllAvailableOptions()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODO's");
    Console.WriteLine("[A]add a TODOs");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

void PrintAllTodo(List<string> todos)
{
    if (todos == null || todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    Console.WriteLine("Your TODOs:");
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}


Console.ReadKey();