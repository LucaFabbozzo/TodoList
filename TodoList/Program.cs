/// Questo programma implementa una semplice applicazione TODO-list da console.
/// Permette all'utente di:
/// - Visualizzare tutti i TODO inseriti
/// - Aggiungere un nuovo TODO
/// - Rimuovere un TODO esistente
/// - Uscire dal programma

/// I metodi ausiliari gestiscono la stampa delle opzioni, la visualizzazione, l'aggiunta e l'eliminazione dei TODO
/// e la conferma dell'opzione selezionata.





// Lista che contiene tutti i TODO inseriti dall'utente
List<string> todos = new List<string>();
// Array delle lettere valide per le opzioni della TODO
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
            PrintAllTodo(todos);
            break;
        case "A":
            AddTodo(todos);
            break;
        case "R":
            RemoveTodo();
            break;
        case "E":
            PrintSelectedOption("I'm about to leave the program!");
            break;
    }
} while (userChoice?.ToUpper() != "E");



//Metodo che permette di stampare a schermo l'opzione scelta
void PrintSelectedOption(string selectedOption)
{
    System.Console.WriteLine("Selected option: " + selectedOption);
}

//Metodo che stampa tutte le opzioni disponibili
void PrintAllAvailableOptions()
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODO's");
    Console.WriteLine("[A]add a TODOs");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
}

//Metodo che stampa tutti i TODO inseriti dall'utente
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
    Console.WriteLine();
}


//Metodo che aggiunge TODO unici alla lista
void AddTodo(List<string> todos)
{
    string todo;
    do
    {
        Console.Write("Enter the TODO description: ");
        todo = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(todo))
        {
            Console.WriteLine("The description cannot be empty.");
            continue;
        }

        // Rimuove eventuali spazi bianchi all'inizio e alla fine della descrizione inserita dall'utente.
        string trimmedTodo = todo.Trim();
        if (todos.Contains(trimmedTodo))
        {
            Console.WriteLine("The description must be unique.");
            todo = null; // Force the loop to continue
        }
        else
        {
            todos.Add(trimmedTodo);
            Console.WriteLine("TODO successfully added:" + trimmedTodo);
            break;
        }
    } while (true);
    Console.WriteLine();
}

//Metodo per la rimozione dei TODO
void RemoveTodo()
{
    if (todos == null || todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }

    Console.WriteLine("Select the index of the TODO you want to remove: ");
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }

    Console.Write("Enter the number of the TODO to remove: ");
    string input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Input cannot be empty. No TODO is removed.");
        Console.WriteLine();
        return;
    }
    int indexTodo;
    if (int.TryParse(input, out indexTodo) && indexTodo >= 1 && indexTodo <= todos.Count)
    {
        string removed = todos[indexTodo - 1];
        todos.RemoveAt(indexTodo - 1);
        Console.WriteLine("TODO removed: " + removed);
    }
    else
    {
        Console.WriteLine("The given index is not valid. No TODO is removed.");
    }
    Console.WriteLine();
}

