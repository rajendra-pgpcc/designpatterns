// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using  DesignPatternsDemo;

Product apple = new DesignPatternsDemo.Product("Apple", Color.GREEN, Size.SMALL);

Product tree = new DesignPatternsDemo.Product("Tree", Color.GREEN, Size.LARGE);

Product house = new DesignPatternsDemo.Product("House", Color.BLUE, Size.LARGE);

Product[] products = { apple, tree, house};

var pf = new ProductFilter();
Console.WriteLine("Filtering GREEN colored products");
foreach(var p in pf.Filter(products, new ColorSpecification(Color.GREEN)))
{
    Console.WriteLine($" - {p.Name} is green.");
}

Console.WriteLine("Filtering Blue colored products");
foreach(var p in pf.Filter(products, 
    new AndSpecification<Product>(new ColorSpecification(Color.BLUE), new SizeSpecification(Size.LARGE))
    ))
{
    Console.WriteLine($" - {p.Name} is {p.Color} and {p.Size}.");
}

Console.WriteLine("Press any key to exit");
Console.ReadKey();
