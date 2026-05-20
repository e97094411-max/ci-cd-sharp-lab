using CalculatorApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(2, 3));
    }
}