namespace DesignPatternsDemo;
public enum Color   
{
    RED,
    BLUE,
    GREEN
};

public enum Size
{
    SMALL,
    MEDIUM,
    LARGE
}

public class Product
{
    public string Name;
    public Color Color;
    public Size Size;

    public Product(string name, Color color, Size size)
    {
        Name = name;
        Size = size;
        Color = color;
    }

    public override string ToString()
    {
        return $"{Name} is in {Color} with size of {Size}";
    }
}