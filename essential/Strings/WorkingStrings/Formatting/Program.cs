float f1 = 123.4f;
int i1 = 2000;

// using indexes and names of variables
Console.WriteLine("{0, -15} {1,10}", "Float Val", "Int Val");
Console.WriteLine("{0, -15} {1, 10}", f1, i1);

// now using interpolation
Console.WriteLine("{0, -15} {1,10}", "Float Val", "Int Val");
Console.WriteLine($"{f1,-15} {i1,10}");

/*  interesting concept 
    alignment value
    positive = right alignment
    negative = left alignment

    in the first example above, using indexes to print. the second number is the alignment value
 */

Console.WriteLine("{0, -8} {1, 44}", "Good", "Bad");