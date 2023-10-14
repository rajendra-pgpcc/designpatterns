namespace LiskovSubstitutionPrincipleDemo;

public class Rectangle
{
    public virtual int Length { get; set; }
    public virtual int Width { get; set; }

    public Rectangle()
    {
        Length = 0;
        Width  = 0;
    }
    public Rectangle(int Length, int Width)
    {
        this.Length = Length;
        this.Width  = Width;
    }

    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Length)}: {Length}";
    }
}