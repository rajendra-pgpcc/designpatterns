namespace DesignPatternsDemo;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> First;
    private readonly ISpecification<T> Second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        this.First = first;
        this.Second = second;
    }

    public bool IsSatisfied(T t)
    {
        return First.IsSatisfied(t) && Second.IsSatisfied(t);
    }
}