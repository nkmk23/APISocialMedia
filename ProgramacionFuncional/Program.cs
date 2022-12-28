
List<string> listOfNames = new List<string>()
{
    "John Doe",
    "Jane Doe",
    "Joe Doe"
};
var a = listOfNames.Aggregate((a, b) => b + " " + a );
Console.WriteLine("Hello, World!");
