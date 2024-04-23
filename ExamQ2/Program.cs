namespace ExamQ2;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account9000 =
            new BankAccount(
                "343432735982", 
                "Ola Nordmann");
        
        Console.WriteLine(account9000.OwnerName);
        Console.WriteLine(account9000.AccountNumber);
        Console.WriteLine("Balance: " + account9000.Balance + " kr");

        account9000.Deposit(500);
        Console.WriteLine("Balance: " + account9000.Balance + " kr");

        account9000.Withdraw(200);
        Console.WriteLine("Balance: " + account9000.Balance + " kr");

        account9000.Withdraw(400);
        Console.WriteLine("Balance: " + account9000.Balance + " kr");

    }
}