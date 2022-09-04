// https://twitter.com/okyrylchuk/status/1556384339151228929

using System.Numerics;

Point p1 = new() { X = 10, Y = 5 };
Point p2 = new() { X = 5, Y = 7 };

Point p3 = p1 + p2;
Point p4 = p1 - p2;
Console.WriteLine(p3);
Console.WriteLine(p4);

public record Point : 
    IAdditionOperators<Point, Point, Point>, 
    ISubtractionOperators<Point, Point, Point>
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator +(Point left, Point right)
    {
        return left with { X = left.X + right.X, Y = left.Y + right.Y };
    }

    public static Point operator -(Point left, Point right) 
    {
        return left with { X = left.X - right.X, Y = left.Y - right.Y };
    }

    public override string ToString() => $"X: {X}; Y: {Y}";
}

