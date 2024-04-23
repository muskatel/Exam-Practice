namespace ExamQ5;

public class BasicCalculator:ICalculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }

        throw new DivideByZeroException();
    }
}