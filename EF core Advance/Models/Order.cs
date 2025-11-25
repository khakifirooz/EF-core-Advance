namespace EF_core_Advance.Models;

public class Order
{
    public int Id { get; set; }
    public double TotalPrice { get; set; }
    public DateOnly OrderDate { get; set; }
    public bool IsDeleted { get; set; }

    public Order(double totalPrice, DateOnly orderDate)
    {
        TotalPrice = totalPrice;
        OrderDate = orderDate;
        IsDeleted = false;
    }
}
