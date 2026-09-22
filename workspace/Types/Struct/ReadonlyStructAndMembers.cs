// 読み取り専用の構造体と読み取り専用のメンバー

var temp = new Temperature(100);
// temp.Celsius = 50; こういうことができない
Console.WriteLine(temp);

var v = new Velocity { X = 3, Y = 4 };
Console.WriteLine(v.Speed);
Console.WriteLine(v);
v.X = 6;
Console.WriteLine(v.Speed);

// 作成後に中身を変更できない
readonly struct Temperature
{
    public double Celsius {get;}
    public Temperature(double celsius) => Celsius = celsius;
    public double Fahrenheit => Celsius * 9.0 / 5.0 + 32.0;
    public override string ToString() => $"{Celsius:F1}°C ({Fahrenheit:F1}°F)";
}

// 構造体全体を不変にする必要がない場合
struct Velocity
{
    public double X
    {
        // メンバーをreadonlyでメンバーだけ不変にできる
        readonly get;
        set;
    }

    public double Y
    {
        readonly get;
        set;
    }

    public readonly double Speed => Math.Sqrt(X * X + Y * Y);

    public readonly override string ToString() => $"({X}, {Y}) speed={Speed:F2}";
}