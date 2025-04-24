namespace Assignment_3._4;

public class Coffee : Beverage
{
    public string BeanType { get; set; }
    public string RoastLevel { get; set; }
    public bool HasCaffeine { get; set; }
    
    public Coffee() {} //defaul constructor
        
    public Coffee(string name, double price, string size, bool isHot, string beanType, string roastLevel, bool hasCaffeine) //constructor for all
    {
        Name = name;
        Price = price;
        Size = size;
        IsHot = isHot;
        BeanType = beanType;
        RoastLevel = roastLevel;
        HasCaffeine = hasCaffeine;
    }
        
    public override string GetDescription()
    {
        return $"{Name}: {RoastLevel} roast {BeanType} beans, " +
               $"{(HasCaffeine ? "Caffeinated" : "Decaf")}, " + //shorthand because it looks cooler
               $"{(IsHot ? "hot" : "cold")}, {Size}"; // it's just a bool with returns based on true/false
    }
}
