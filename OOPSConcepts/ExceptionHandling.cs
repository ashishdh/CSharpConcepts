using System;

internal static class ExceptionHandling
{    
    public static void Run()
    {
        try
        {
            ProcessPayment(1000);
            Console.WriteLine("Payment successful!");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Payment failed: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Thank you for shopping with us.");
        }
    }
   
    static void ProcessPayment(int amount)
    {
        int balance = 500;

        if (amount > balance)
        {
            throw new InsufficientBalanceException();
        }
    }
}

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException()
        : base("Not enough balance in your account.") { }
}
