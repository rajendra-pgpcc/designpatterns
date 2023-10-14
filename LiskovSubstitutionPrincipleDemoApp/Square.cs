namespace LiskovSubstitutionPrincipleDemo;

public class Square : Rectangle
{
    public override int Length { get => base.Length; set => base.Length = base.Width = value; }
    public override int Width { get => base.Width; set => base.Width = base.Length = value;}
}