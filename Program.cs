// See https://aka.ms/new-console-template for more information
Console.Write("Enter 1st number :");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number :");
int secondNumber = Convert.ToInt32(Console.ReadLine());

string customer = 
    firstNumber >= secondNumber ? "True" : "False";
    Console.Write("Permission : " + customer);

