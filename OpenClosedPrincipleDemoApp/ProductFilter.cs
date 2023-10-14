namespace DesignPatternsDemo;

public class ProductFilter : IFilter<Product>
{

    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach(var item in items)
        {
            if(spec.IsSatisfied(item))
            yield return item;
        }
    }

}