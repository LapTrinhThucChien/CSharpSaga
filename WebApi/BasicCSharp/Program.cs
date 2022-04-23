// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

A a = new A();
Console.WriteLine(a.PropertyMutable.IncrementX());
Console.WriteLine(a.PropertyMutable.IncrementX());

Console.WriteLine(a.ReadonlyMutable.IncrementX());
Console.WriteLine(a.ReadonlyMutable.IncrementX());


Console.WriteLine(a.FieldMutable.IncrementX());
Console.WriteLine(a.FieldMutable.IncrementX());


struct Mutable
{
    public Mutable(int x)
    {
        X = x;
    }

    public int IncrementX()
    {
        X++;
        return X;
    }

    public int X { get;  set ; }
}

class A
{
    public A()
    {
        PropertyMutable = new Mutable(1);
        ReadonlyMutable = new Mutable(1);
        FieldMutable = new Mutable(1);
    }

    public Mutable PropertyMutable { get; }

    public readonly Mutable ReadonlyMutable;

    public Mutable FieldMutable;
}

struct Point
{
    public int X { get; set; }

    public int Y { get; set; }

    public Point(int x, int y): this()
    {
        X = x;
        Y = y;
    }

    public Point InCrement(int x, int y)
    {
        return new Point(x, y);
    }
}