// 
// .net data types
// integral numeric >> byte, integer, long 
// floating point >> float, double, decimal
// char >> 'a'
// bool >> true or false
// string >> "abse"
// object >> {...}

// value types >> when used as arguement a copy is made
// reference types 

int a = 4;
char c = 'D';
float f = 1.56f;
decimal d = 420.20m;
int b = default;
bool tf = default;

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");

// implicit type conversion
Console.WriteLine($"{c + a}");
Console.WriteLine($"{(char)(c + a)}");
Console.WriteLine($"{f + a}");

// create instance of strut
s s1;
s1.a = 5;
s1.b = false;

// perform operation on struct
void StructOp(s theStruct)
{
    theStruct.a = 20;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

Console.WriteLine("Structs passed by copy");
Console.WriteLine($"{s1.a}, {s1.b}");

// uses a copy so no change. 
StructOp(s1);
Console.WriteLine($"{s1.a}, {s1.b}");

// create instance of class
MyClass cl = new MyClass { a = 5, b = false };

void ClassOp(MyClass theClass)
{
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}

Console.WriteLine("Objects passed by reference");
Console.WriteLine($"{cl.a}, {cl.b}");

// changes original
ClassOp(cl);
Console.WriteLine($"{cl.a}, {cl.b}");

class MyClass
{
    public int a;
    public bool b;
}

struct s
{
    public int a;
    public bool b;
}