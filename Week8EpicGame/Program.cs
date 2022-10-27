string folderPath = @"C:\data";
string heroFile = "heroes.txt";
string villainFail = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFail));


//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "scooby-Doo" };
//string[] villains = { "Voldemort", "Dracula", "Joker", "Sauron", "Sookoll" };
string[] weapon = { "Võlukepp", "Mõõk", "Vibu", "Automaat relv", "Kivid" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");



static string GetRandomValueFromArray(string[] someArray)
{
Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}