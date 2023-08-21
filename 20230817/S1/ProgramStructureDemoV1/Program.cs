using ProgramStructureDemoV1.Services;


namespace ProgramStructureDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* Block of code Starts here */

            WriteLine("Hello .NET 8 World!"); /* This is a statement and it ends with semi colon. */

            WriteLine("Enter your name: ");
            var name = ReadLine();
            WriteLine($"Hello {name}!");

            int num1 = 10, num2 = 20; /* Variable declaration and initialization. */
            Maths maths = new(); /* Instantiation of Maths class. */
            WriteLine($"{num1} + {num2} = {maths.AddNumbers(num1, num2)}");

            /* Accessing static members of a class. */
            WriteLine($"{num1} + {num2} = {Maths.AddNumbersV1(num1, num2)}");
            WriteLine($"Max value is {Maths.MaxValue}");

            /* The dot operator (.) is used to access members of a namespace, type, or object. */
            WriteLine("Press any key to exit.");
            ReadKey();

            // Console.ReadKey(); & Console.Readkey(); are different /* C# is a case sensitive language. */

        }
    }
}