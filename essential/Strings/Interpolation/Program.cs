int a = 100;
float b = 250.0f;
string c = "CSharp";

// the old way use placeholders
Console.WriteLine("The values are {0}, {1} and {2}", a, b, c);

// easier to read code using interpolation
Console.WriteLine($"The values are {a}, {b} and {c}");
Console.WriteLine($"{c} in uppercase is {c.ToUpper()}");

// complex objects can be embedded in strings this way too
DateTime now = DateTime.Now;
Console.WriteLine($"Today is {now}");

// My own adventure
List<string> friends = new List<string> { "Monica", "Harry", "Justin", "Womack", "Florida" };
for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"I have a friend named {friends[i]}");
}