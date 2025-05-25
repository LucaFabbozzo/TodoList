/// Questo programma implementa una semplice applicazione TODO-list da console.
/// Permette all'utente di:
/// - Visualizzare tutti i TODO inseriti
/// - Aggiungere un nuovo TODO
/// - Rimuovere un TODO esistente
/// - Uscire dal programma

/// Le funzioni ausiliarie gestiscono la stampa delle opzioni, la visualizzazione dei TODO
/// e la conferma dell'opzione selezionata.





// Lista che contiene tutti i TODO inseriti dall'utente
List<string> todos = new List<string>();
// array delle lettere valide per le opzioni della TODO
string[] validChoices = { "S", "A", "R", "E" };
// Variabile per memorizzare la scelta dell'utente nel menu
string userChoice;


/// Il programma utilizza un ciclo do-while per mostrare un menu di opzioni all'utente.
/// Le scelte valide sono:
///   S - Visualizza tutti i TODO
///   A - Aggiungi un nuovo TODO
///   R - Rimuovi un TODO
///   E - Esci dal programma

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
            Console.WriteLine();
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



//Funzione che permette di stampare a schermo l'opzione scelta
void PrintSelectedOption(string selectedOption)
{
    System.Console.WriteLine("Selected option: " + selectedOption);
}

//Funzione che stampa tutte le opzioni disponibili
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
    //Controlla se non ci sono ancora TODO inseriti dall'utente
    if (todos == null || todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    Console.WriteLine("Your TODOs:");
    /// </summary>
    /// Itera attraverso la lista dei TODO e stampa ogni elemento.
    /// </summary> 
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}


Console.ReadKey();