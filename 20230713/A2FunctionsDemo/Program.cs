// See https://aka.ms/new-console-template for more information

void SayHelloWorld()
{
    Console.WriteLine("Hello, World!");
}

void SayHello(string name)
{
    Console.WriteLine($"Hello, {name}!");
}
// int AddNumbers(int a, int b){
//     Console.WriteLine(a+b);
// }

int GetAge(){
    Console.WriteLine("How old are you dude ?");
    return int.Parse(Console.ReadLine());
  
}

DateTime BornOn(int age){
    return DateTime.Now.AddYears(-age);
}


String name;
String input = "";
SayHelloWorld();
Console.WriteLine("Who Are you ?");
try
{
    //SayHello(Console.ReadLine());
    input = Console.ReadLine();
    String[] inputarray = input.Split(" ");
    if (inputarray.Length == 1)
        name = inputarray[0];
    else
        name = inputarray[inputarray.Length - 1];

    SayHello(name);
    Console.WriteLine("......");
    int age = GetAge();
    Console.WriteLine($"Your age is {age}");
    Console.WriteLine("......");
    Console.WriteLine($"You Born On : {BornOn(age)}");



}
catch (Exception e)
{
    Console.WriteLine(e);
}


