namespace EF_core_Advance.Models;

public class CryptoPayment : IPamentProcesor
{
    public void ProcessPayment(int Price)
    {
        Console.WriteLine($"Process crypto payment for price: {Price}");
    }
}