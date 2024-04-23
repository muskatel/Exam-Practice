namespace ExamQ4;

class Program
{
    static void Main(string[] args)
    {
        
        Employee craig = new Employee(1, "Craig", 30000);
        Manager atle = new Manager(2, "Atle", 35000, 10000);
        
        Console.WriteLine(craig);
        Console.WriteLine(atle);
    }
}