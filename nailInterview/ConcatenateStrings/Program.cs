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
    }
}

// the foundation of string concatenation lies in string creation
// String Creation
    // Strings are immutable
    // Characters cannot be changed
    // Length cannot be changed
    // In concatenation, create a new String, leaaving old String unaltered
    // Use String Builder object to make program more efficient