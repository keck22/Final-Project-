using System; 
public class BankAccount  {
  public string AccountNumber {get; set;}
  public string Name {get; set;}
  public double Balance {get; set;}
  public DateTime DateCreated {get; set;}

  public BankAccount() {
    DateCreated = DateTime.Today;
  }
  public BankAccount(string AccountNumber, string Name, string Balance)  {
  }
  public double Deposit(decimal amount) {
  Balance = Balance + amount;
  Console.WriteLine(Balance);
  }
  
  public double Withdraw(decimal amount) {
    if (Balance > amount) {
    Balance = Balance - amount
    }
     else 
    Console.WriteLine("Error");
  }

   public double CalculateInterest() {
    Console.WriteLine("This method will calculate interest");
   else 
    Console.WriteLine("Error");

  }
  public double CalculateInterest() {
    Console.WriteLine("This method will calculate interest");

  }
}