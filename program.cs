Console.WriteLine("Welcome to the bank");

BankAccount account = new BankAccount(11000);
//BankAccount account = new BankAccount("new account name"); it will know to use the string version under BankAccount 

//account.balance = 100;
try{ 
account.makeDeposit(-1);
} catch(Exception ex) {
    Console.WriteLine(ex.Message); 
}

Console.Write($" Your balance is: account.balance {account.getBalance()} ");
Console.WriteLine($" Account Number: {account.accountNumber}");

//public string accountNumber {
//   public string accountNumber {get; set;} ="";
//   public decimal balance {get; set;} ="";
//}
 