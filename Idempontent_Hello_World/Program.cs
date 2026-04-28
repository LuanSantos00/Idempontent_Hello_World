
Console.Write("Write a new word: ");
var newWord = Console.ReadLine()!;

const string filePath = "idempotemcy.txt";

if (HasAlreadyExecuted(filePath, newWord))
{
    Console.WriteLine($"{newWord} has executed before.");
	return;
}

Console.WriteLine($"{newWord} inserted");

MarkAsExecuted(filePath, newWord);

static bool HasAlreadyExecuted(string filePath, string key)
{
	if (File.Exists(filePath) is false)
		return false;

    var keys = File.ReadAllLines(filePath);
    return Array.Exists(keys, k => k == key);
}

static void MarkAsExecuted(string filePath, string key)
{
	File.AppendAllText(filePath, key + Environment.NewLine);
}