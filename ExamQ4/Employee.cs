namespace ExamQ4;

public class Employee
{
    private int Id;
    private string Name;
    protected double BaseSalary;

    public Employee(int id, string name, double baseSalary)
    {
        Id = id;
        Name = name;
        BaseSalary = baseSalary;
    }

    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }

    public override string ToString()
    {
        return $"Type: {GetType().Name}, CalculatedSalarey: {CalculateSalary()}, " +
               $"Id: {Id}, Name: {Name}, BaseSalary: {BaseSalary}";
    }
}