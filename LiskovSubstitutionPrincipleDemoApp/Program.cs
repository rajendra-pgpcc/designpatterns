using System.Security.Cryptography.X509Certificates;

namespace LiskovSubstitutionPrincipleDemo;
public class Demo
{
    static int Area(Rectangle r) => r.Length * r.Width;
    public static void Main(string[] args){
        Rectangle rc = new(2,3);
        System.Console.WriteLine($"{rc} area is {Area(rc)}");
        
        Square sq = new();
        sq.Width = 4;
        System.Console.WriteLine($"{sq} area is {Area(sq)}");
        
    }
}