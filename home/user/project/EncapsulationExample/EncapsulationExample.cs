using System;

// Top-level statements
// Create a new bank account
BankAccount account = new BankAccount("123456789", 1000m);

// Display initial balance
Console.WriteLine($"Account Number: {account.AccountNumber}");
Console.WriteLine($"Initial Balance: {account.Balance}");

// Deposit money
account.Deposit(500m);
Console.WriteLine($"Balance after deposit: {account.Balance}");

// Withdraw money
account.Withdraw(200m);
Console.WriteLine($"Balance after withdrawal: {account.Balance}");

public class BankAccount
{
    // Private fields to store account information
    private string? accountNumber; // Marked as nullable
    private decimal balance;

    // Public property to access account number
    public string? AccountNumber
    {
        get { return accountNumber; }
        private set { accountNumber = value; }
    }

    // Public property to access and modify balance
    public decimal Balance
    {
        get { return balance; }
        private set
        {
            if (value >= 0)
            {
                balance = value;
            }
            else
            {
                throw new ArgumentException("Balance cannot be negative.");
            }
        }
    }

    // Constructor to initialize account
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Method to deposit money
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            throw new ArgumentException("Invalid withdrawal amount.");
        }
    }
}