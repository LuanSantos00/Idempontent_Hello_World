
var idempotencyKey = "hello-world";
var filePath = "idempotemcy.txt";

if (HasAlreadyExecuted(filePath, idempotencyKey))
{
    Console.WriteLine("Hello world has executed before.");
	return;
}

Console.WriteLine("Hello world!");

MarkAsExecuted(filePath, idempotencyKey);

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