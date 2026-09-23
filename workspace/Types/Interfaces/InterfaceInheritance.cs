// インターフェイスの継承

interface IDrawable
{
    void Draw();
}

// 継承
interface IShape : IDrawable
{
    double Area {get;}
}

public class Circle(double radius) : IShape // IDrawableを継承しているのでvoid draw()を守る
{
    public double Area => Math.PI * radius * radius;
    public void Draw() => Console.WriteLine($"Drawing circle with area {Area:F2}");
}