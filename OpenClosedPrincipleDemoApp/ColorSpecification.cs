namespace DesignPatternsDemo;

public class ColorSpecification : ISpecification<Product>
{
    Color color;
    public ColorSpecification(Color color)
    {
        this.color = color;
    }
    public bool IsSatisfied(Product t)
    {
        return t.Color == color;
    }
}