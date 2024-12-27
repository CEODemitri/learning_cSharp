// small console application practicing loops in c#
// no need for seperate repo; only when ready without a tutorial or etc...

Console.WriteLine("-------------------");
Console.WriteLine("| Adventure Quest |");
Console.WriteLine("-------------------");

// Create Character
Console.WriteLine("Enter your character's name: ");
string playerName = Console.ReadLine();

Console.WriteLine("Pick a Character Class: [Spirit, Magician, Werewolf, Archer]");
// sanatize user input
// only except the given classes, all other inputs are not accepted and try again

string playerClass = Console.ReadLine().ToLower();

// capitalize first letter of playerClass
playerClass = char.ToUpper(playerClass[0]) + playerClass.Substring(1).ToLower();


while (playerClass!= "Spirit" && playerClass!= "Magician" && playerClass!= "Werewolf" && playerClass!= "Archer")
{
    Console.WriteLine("Invalid class, please try again: ");
    playerClass = Console.ReadLine().ToLower();
};

Console.WriteLine($"Welcome, {playerName}! You are a {playerClass}.");

Console.ReadKey();

