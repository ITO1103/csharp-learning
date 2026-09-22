// 構造体を宣言する

var p1 = new Point{X = 3, Y = 4};
var p2 = p1; // 参照ではないので別のオブジェクトになる
p2.X = 10;

Console.WriteLine(p1);
Console.WriteLine(p2);

var p3 = p1.DistanceTo(p2);
Console.WriteLine(p3);

struct Point
{
    public double X {get; set;}
    public double Y {get; set;}

    public readonly double DistanceTo(Point other){
        var dx = X - other.X;
        var dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public override string ToString() => $"({X}, {Y})";
};


