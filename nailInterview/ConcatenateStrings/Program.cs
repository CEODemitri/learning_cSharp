using System.Text;
// import Text library to access StringBuilder object

public class HelloWorld
{
    static void Main(string[] args)
    {
        string firstName = "Hannah";
        string lastname = "Echols";

        // Simple Concatenation
        string name = firstName + " " + lastname;

        // StringBuilder is faster and more efficient than string concatenation
        // gives access to Append, Insert and Remove operations on object
        StringBuilder stringBuilder = new StringBuilder("abc");
        stringBuilder.Append("def");
        stringBuilder.Append("ghi");
        stringBuilder.Insert(0, name);
        String alpha = stringBuilder.ToString();
        Console.WriteLine(alpha);

        // new example
        StringBuilder zodiac = new StringBuilder("Leo");
        zodiac.Append(" Virgo");
        Console.WriteLine(zodiac);
        zodiac.Append(" Scorpio");
        Console.WriteLine(zodiac);

        // StringBuilder is used when performance is critical
        // StringBuilder is thread-safe, meaning multiple threads can access and modify it simultaneously
        // StringBuilder is useful for building strings that need to be changed frequently
        // StringBuilder is also useful for building strings that need to be shared between multiple threads

        StringBuilder baseName = new StringBuilder("rain");
        Console.WriteLine($"original: {baseName}");
        baseName.Append("mane");
        Console.WriteLine(baseName);
    }
}

// the foundation of string concatenation lies in string creation
// String Creation
// Strings are immutable
// Characters cannot be changed
// Length cannot be changed
// In concatenation, create a new String, leaaving old String unaltered
// Use String Builder object to make program more efficient