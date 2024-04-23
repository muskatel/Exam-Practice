namespace ExamQ5;

class Program
{
    static void Main(string[] args)
    {
        List<ICalculator> calculators = new List<ICalculator>();
        calculators.Add(new BasicCalculator());
        calculators.Add(new RoundingCalculator());

        foreach (ICalculator calculator in calculators)
        {
            Console.WriteLine(calculator.GetType().Name);
            Console.WriteLine($"Add: 5,5 + 3,3 = {calculator.Add(5.5,3.3)}");
            Console.WriteLine($"Subtract: 7,2 - 2,1 = {calculator.Subtract(7.2,2.1)}");
            Console.WriteLine($"Multiply: 2,5 * 4 = {calculator.Multiply(2.5,4)}");
            Console.WriteLine($"Divide: 9 / 2 = {calculator.Divide(9,2)}");
        }
    }
}