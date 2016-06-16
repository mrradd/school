
package rad;
import java.util.Scanner;

/*****************************************************************************
 * Conrad Horton
 * CSC203
 * June 2016
 * Week1 Lab2 Part3: Account
 * 20160615
 ******************************************************************************
 * Modify class Account (Fig. L 3.1) to provide a method called debit that
 * withdraws money from an Account. Ensure that the debit amount does not
 * exceed the Account’s balance. If it does, the balance should be left
 * un-changed and the method should print a message indicating "Debit amount
 * exceeded account balance." Modify class AccountTest (Fig. L 3.2) to test
 * method debit.
 *****************************************************************************/
public class Account
  {
  private double balance;
  
  //CTOR.
  public Account(double initialBalance)
    {
    if (initialBalance > 0.0)
      balance = initialBalance;
    }
  
  //Increase balance.
  public void credit(double amount)
    {
    balance += amount;
    }

  //Prevent overdraw. Decrease balance.
  public void debit(double amount)
    {
    if (balance < amount)
      System.out.println("Debit amount exceeds account balance.");
    else
      balance -= amount;
    }
  
  //Return the balance of the Account.
  public double getBalance()
    {
    return balance;
    }
  
  //Using Main in place of AccountTest class, since AccountTest was pointless.
  //This is what main is for anyway.
  public static void main(String args[])
    {
    //Make account objs.
    Account account1 = new Account(50.00);
    Account account2 = new Account(-7.53);
    
    //Show balances.
    System.out.printf("account1 balance: $%.2f\n", account1.getBalance());
    System.out.printf("account2 balance: $%.2f\n", account2.getBalance());
    
    //Prep for input.
    Scanner input = new Scanner(System.in);
    double withdrawalAmount;
    
    //Take withdraw amount from user for account1.
    System.out.print("\nEnter withdrawal amount from account1: ");
    withdrawalAmount = input.nextDouble();
    System.out.printf("\nWithdrawing $%.2f for account1...\n", withdrawalAmount);
    account1.debit(withdrawalAmount);
    
    //Take withdraw amount from user for account2.
    System.out.print("\nEnter withdrawal amount from account2: ");
    withdrawalAmount = input.nextDouble();
    System.out.printf("\nWithdrawing $%.2f for account2...\n", withdrawalAmount);
    account2.debit(withdrawalAmount);
    
    //Show balances.
    System.out.printf("account1 balance: $%.2f\n", account1.getBalance());
    System.out.printf("account2 balance: $%.2f\n", account2.getBalance());
    }
  }