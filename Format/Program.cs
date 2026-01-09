using System.Security.Cryptography;
try
{
    BankAccount bankAccount = new BankAccount();

    Console.Write("Enter the account holder name: ");
    bankAccount.AccountHolderName = Console.ReadLine();

    Console.Write("Enter the account number: ");
    bankAccount.AccountNumber = int.Parse(Console.ReadLine()); //FormatException can occur here If the input is not a valid integer

    Console.Write("Enter the current balance: ");
    bankAccount.CurrentBalance = double.Parse(Console.ReadLine());

    Console.WriteLine("\n--- New bank account details ---");
    Console.WriteLine($"Account Holder Name: {bankAccount.AccountHolderName}");
    Console.WriteLine($"Account Number: {bankAccount.AccountNumber}");
    
    Console.WriteLine($"Current Balance: {bankAccount.CurrentBalance}");
}
catch (FormatException ex)
{
    Console.WriteLine("Input format is incorrect. Please enter the data in the correct format.");
    Console.WriteLine($"Error Details: {ex.Message}");
}

