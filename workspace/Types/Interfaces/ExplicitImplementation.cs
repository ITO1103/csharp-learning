// 明示的な実装

// メートルを返す
interface IMetric
{
    double GetDistance();
}

// フィートを返す
interface IImperial
{
    double GetDistance();
}


// 複数のインターフェイスを実装できる
public class Runway(double meters) : IMetric, IImperial
{
    double IMetric.GetDistance() => meters;
    double IImperial.GetDistance() => meters * 3.28084;
}