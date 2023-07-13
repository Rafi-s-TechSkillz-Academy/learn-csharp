// See https://aka.ms/new-console-template for more information
int age; // declaring

// Console.WriteLine(age); // error: use of unassigned local variable 'age'




age = 18; // initializing

Console.WriteLine(age); // error: use of unassigned local variable 'age'




int rollNumber = 1, marks = 100; // declaring and initializing multiple variables

Console.WriteLine($"{rollNumber} {marks}"); // string interpolation




Console.WriteLine($"Int: {sizeof(int)} byte(s) of memory. Its Min and Max Values are {int.MinValue} and {int.MaxValue}");




age = 25; // re-initializing

Console.WriteLine(age);




Console.WriteLine(int.Parse("123")); // converting string to int