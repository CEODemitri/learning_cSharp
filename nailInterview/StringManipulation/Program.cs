using System.Linq;
// NORMALIZE STRING INPUT
// before processing a string, may be helpful to normalize to more common form to aid efficiency

// ai written
// public class NormalizeString
// {
//     public static string Normalize(string input)
//     {
//         // convert to lower case
//         string lowerCase = input.ToLower();

//         // replace spaces with underscores
//         string underscores = lowerCase.Replace(" ", "_");

//         // replace non-alphanumeric characters with underscores
//         string sanitized = underscores.Replace("[^a-z0-9_]", "_");

//         return sanitized;
//     }
// }

public class NormalizeString
{
    public static void Main(string[] args)
    {
        Console.WriteLine(normalizeString("   Hey there,   BUDDY!"));
        Console.WriteLine(isUppercase("BUDDY"));
        Console.WriteLine(isLowercase("hey there buddy"));
    }

    static String normalizeString(String input)
    {
        // string lowerCase = input.ToLower();
        // string trim = lowerCase.Trim(" ", "_");
        // string sanitized = trim.Replace("[^a-z0-9_]", "_");
        // return sanitized;
        // OR
        return input.ToLower().Trim().Replace(",", "");
    }

    // Validate a String
    static Boolean isUppercase(string s)
    {
        return s.All(char.IsUpper);
    }

    static Boolean isLowercase(string s)
    {
        Console.WriteLine(s.ToLower()); // why does this return my exact input but boolean method isLower returns false
        return s.All(char.IsLower);
    }

    // data in a string
    static void parseContents(string input)
    {
        Console.WriteLine("Option 1");
        foreach (char c in input)
        {
            Console.WriteLine(c);
        }

        Console.WriteLine("Option 2");
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
        }
    }
    // String input = "Hello";
    // Console.WriteLine(input.ToLower().Contains("ll"));

    // parseContents(input);
}