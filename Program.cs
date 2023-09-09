Console.WriteLine("Please enter a number:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter a second number:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("What would you like to do?");
Console.WriteLine("[A] - Addition");
Console.WriteLine("[B] - Subtraction");
Console.WriteLine("[C] - Multiplication");
Console.WriteLine("[D] - Division");

string operationInput = Console.ReadLine();
string operationUpper = operationInput.ToUpper();

if (operationUpper != "A" && operationUpper != "B" && operationUpper != "C" && operationUpper != "D")
{
    Console.WriteLine("Please choose a valid operation");
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
}
else
{
    switch (operationUpper)
    {
        case "A":
            Console.WriteLine($"{a} + {b} = {a + b}");
            break;
        case "B":
            Console.WriteLine($"{a} - {b} = {a - b}"); 
            break;
        case "C":
            Console.WriteLine($"{a} * {b} = {a * b}"); 
            break;
        case "D":
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = {a / (double)b}");
            }
            break;
    }
    Console.ReadKey();
}
