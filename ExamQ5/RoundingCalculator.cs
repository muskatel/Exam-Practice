namespace ExamQ5;

public class RoundingCalculator: ICalculator
{
    public double Add(double num1, double num2)
    {
        return Math.Round(num1 + num2);
    }

    public double Subtract(double num1, double num2)
    {
        return Math.Round(num1 - num2);
    }

    public double Multiply(double num1, double num2)
    {
        return Math.Round(num1 * num2);
    }

    public double Divide(double num1, double num2)
    {
        if (num2 != 0)
        {
            return Math.Round(num1 / num2);
        }

        throw new DivideByZeroException();
    }
}