namespace EF_core_Advance.Models;

public class PayPalPayment : IPamentProcesor
{
    public void ProcessPayment(int Price)
    {
        Console.WriteLine($"Process paypal payment for price: {Price}"); 
    }
}
