namespace ExamQ4;

public class Manager: Employee
{
    private double Bonus;

    public Manager(int id, string name, double baseSalary, double bonus) 
        : base(id, name, baseSalary)
    {
        Bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override string ToString()
    {
        return base.ToString() + ", Bonus: " + Bonus;
    }
}