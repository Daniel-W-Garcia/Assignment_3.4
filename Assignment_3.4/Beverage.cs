namespace Assignment_3._4;

public abstract class Beverage
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Size { get; set; }
    public bool IsHot { get; set; }
        
    public abstract string GetDescription();
}