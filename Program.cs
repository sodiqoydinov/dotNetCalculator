//  My first Project in C#, (.Net) :)
Console.Write("Enter first number: ");
decimal number1 = Convert.ToInt64(Console.ReadLine());

Console.Write("Enter second number: ");
decimal number2 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Enter operator: (* / + -): ");
char arithmetic = Convert.ToChar(Console.ReadLine());

switch(arithmetic)
{
    case '*':
        Console.WriteLine($"{number1} * {number2} = {number1*number2}");
        break;
    
    case '/':
        Console.WriteLine($"{number1} / {number2} = {number1/number2}");
        break;

    case '+':
        Console.WriteLine($"{number1} + {number2} = {number1+number2}");
        break;
    
    case '-':
        Console.WriteLine($"{number1} - {number2} = {number1-number2}");
        break;
    
    default:
        Console.WriteLine("Error");
        break;
}