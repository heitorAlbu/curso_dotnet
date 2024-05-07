using projeto1.models;
var cg1 = new ConsoleGame("DayZ", 4);
var cg2 = new ConsoleGame("Project Zomboid", 2);
var cg3 = new ConsoleGame("Cyber Punk", 1);
var cg4 = new ConsoleGame("GTA V", 9);
var cg5 = new ConsoleGame("Prince of Persia", 19);
var cg6 = new ConsoleGame("Call of Duty", 8);
var cg7 = new ConsoleGame("Valheim", 17);
var cg8 = new ConsoleGame("Samurai Shodow", 7);
var cg9 = new ConsoleGame("King of fighters", 1);
var cg10 = new ConsoleGame("Double Dragon", 5);


var dicConsoleGame = new Dictionary<string, ConsoleGame>() { };

dicConsoleGame.Add("1", cg1);
dicConsoleGame.Add("2", cg2);
dicConsoleGame.Add("3", cg3);
dicConsoleGame.Add("4", cg4);
dicConsoleGame.Add("5", cg5);
dicConsoleGame.Add("6", cg6);
dicConsoleGame.Add("7", cg7);
dicConsoleGame.Add("8", cg8);
dicConsoleGame.Add("9", cg9);
dicConsoleGame.Add("10", cg10);

void ListarTodos()
{
    foreach (var console in dicConsoleGame)
    {
        Console.WriteLine("cód :  " + console.Key + " Título : | " + console.Value.Nome + " | qtd : " + console.Value.Quantidade);
    }
}







