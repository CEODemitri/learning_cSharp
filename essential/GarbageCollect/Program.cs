void BigOperation()
{
    byte[] myArray = new byte[1000000];

    Console.WriteLine($"Allocated memory is : {GC.GetTotalMemory(false)}");
    Console.ReadLine();
}

// Retrieve and print total memory allocated
Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
Console.ReadLine();

// Call the function that allocated large memory chunk
BigOperation();

// Force a garbage collection
GC.Collect();
// will probably never need to call this function. demonstration and testing purposes

// Retrieve and print total memory allocated
Console.WriteLine($"Allocated memory is: {GC.GetTotalMemory(false)}");
Console.ReadLine();

