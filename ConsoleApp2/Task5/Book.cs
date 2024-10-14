namespace Task5;

public class Book : Product
{
    public int PageCount { get; set; }
    public string Publisher { get; set; }
    public List<string> Authors { get; set; }
}