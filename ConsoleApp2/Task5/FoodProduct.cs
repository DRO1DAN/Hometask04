namespace Task5;

public class FoodProduct : Product
{
    public DateTime ExpirationDate { get; set; }
    public int Quantity { get; set; }
    public string UnitOfMeasure { get; set; }
}