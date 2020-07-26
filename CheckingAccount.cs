using System;
public class CheckingAccount {}
public decimal Balance {get; set;}

public double CalculateInterest() {
 Balance = Balance*.0075
    Console.WriteLine("Added interest and updated balance");
}
public double Withdraw() {
 { if (Balance < 500)
  Console.WriteLine("Insufficient balance");
 }
 else Withdraw()
}