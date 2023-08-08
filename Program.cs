Console.WriteLine("Switch expression");
Console.Write("Enter 1st number : ");
int a = Convert.ToInt32(Console.ReadLine());
int aA = (int)a;

Console.Write("Enter 2nd number : ");
int b = Convert.ToInt32(Console.ReadLine());
int bB = (int)b;


Console.Write("Enter operation : ");
string c = Convert.ToString(Console.ReadLine());



string result = c switch {
    "+" => $"{aA} + {bB} = {aA + bB}",
    "-" => $"{aA} - {bB} = {aA - bB}",
    "*" => $"{aA} * {bB} = {aA * bB}",
    "/" => $"{aA} / {bB} = {aA / bB}",
    _ => "Nothing to done",
};
Console.WriteLine(result);