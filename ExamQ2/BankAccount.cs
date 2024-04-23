namespace ExamQ2;

public class BankAccount
{
    
    #region Part A
    private double _balance;
    public string AccountNumber { get ; init; }
    public string OwnerName { get; set; }

    //public double Balance => _balance;

    public double Balance
    {
        get { return _balance; }
    }
    
    #endregion

    #region Part B
    public bool Deposit(double amount)
    {
        Console.WriteLine($"Attempting to deposit {amount} kr");
        
        if (amount <= 0)
        {
            Console.WriteLine("Cannot deposit negative number (or zero).");
            return false;
        }

        _balance += amount;
        return true;
    }
    
    public bool Withdraw(double amount)
    {
        Console.WriteLine($"Attempting to withdraw {amount} kr");
        
        if (amount > _balance)
        {
            Console.WriteLine("Cannot withdraw more than balance.");
            return false; 
        }
        
        if (amount <= 0)
        {
            Console.WriteLine("Cannot withdraw negative number (or zero).");
            return false;
        }

        _balance -= amount;
        return true;
    }
    
    #endregion
    
    #region Part C

    public BankAccount(string accountNumber, string ownerName)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
    }

    #endregion
}