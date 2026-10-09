// ポリモーフィズム

using System;
using System.Collections.Generic;

// 派生クラスをShape型としてまとめて扱う
List<Shape> shapes =
[
    new Rectangle(),
    new Triangle(),
    new Circle()
];

foreach (Shape shape in shapes)
{
    // 実際の型に対応するDrawを呼び出す
    shape.Draw();
}

public class Shape
{
    public int X { get; init; }
    public int Y { get; init; }
    public int Height { get; init; }
    public int Width { get; init; }

    public virtual void Draw()
    {
        Console.WriteLine("Performing base class drawing tasks");
    }
}

public class Circle : Shape
{
    // ShapeのDrawをoverrideする
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
        // 基底クラスのDrawも呼び出す
        base.Draw();
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
        base.Draw();
    }
}
