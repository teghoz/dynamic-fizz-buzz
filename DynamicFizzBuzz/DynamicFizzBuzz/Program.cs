// See https://aka.ms/new-console-template for more information
using DynamicFizzBuzz;

Console.WriteLine("Hello, World!");

var dynamicFizzBuzz = new DynamicFizzBuzz.DynamicFizzBuzz();
var dynamicFizzBuzzRequest = new DynamicFizzBuzzRequest()
{
    MaxNumber = 50,
    Configurations = new Dictionary<int, string> {
        { 3, "Fizz" },
        { 5, "Buzz" },
        { 7, "Bazz" }
    }
};

dynamicFizzBuzz.Handle(dynamicFizzBuzzRequest, (result) => { Console.WriteLine(result); });
Console.ReadKey();