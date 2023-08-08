// See https://aka.ms/new-console-template for more information
Console.WriteLine("Switch operatori");
Console.WriteLine("Calculator");
Console.Write("Type 1st number : ");
string firstNumber =Convert.ToString(Console.ReadLine());
int a = Convert.ToInt32(firstNumber);


Console.Write("Type 2nd number : ");
string secondNumber =Convert.ToString(Console.ReadLine());
int b = Convert.ToInt32(secondNumber);

Console.Write("Operator (+ , - , * , / ) : ");
char opA = Convert.ToChar(Console.ReadLine());

switch (opA) {
    case '+' : 
        Console.WriteLine($"{a} + {b} = {a + b}");
        break;
    case '-' : 
        Console.WriteLine($"{a} - {b} = {a - b}");
        break;
    case '*' : 
        Console.WriteLine($"{a} * {b} = {a * b}");
        break;
    case '/' : 
        Console.WriteLine($"{a} / {b} = {a / b}");
        break;
    case '%' : 
        Console.WriteLine($"{a} % {b} = {a % b}");
        break;
    default : 
        Console.WriteLine("Nothing to do");
        break;
}


// Console.Write("Type is operator : + , -, * , / : ");
// char countnumber = Convert.ToChar(Console.Read());

// Console.WriteLine("Type 2nd number : ");
// int secondNumber = Convert.ToInt32(Console.Read());

// Console.WriteLine($"{firstNumber} {countnumber} {secondNumber} = {firstNumber + secondNumber}");



