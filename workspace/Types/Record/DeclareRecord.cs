// レコードを宣言する
// 中の値で比較できるという認識？
// public record class Personと実質同じ
// init専用なので初期化値から変更不可
public record Person(string FirstNam, string LastName);

// record structはreadonlyを追加することでinit専用になる
public record struct Coordinate(double Latitude, double Longitude);

public readonly record struct Temperature(double Celsius)
{
    public double Fahrenheit => Celsius * 9.0 / 5.0 + 32.0;
}

// プロパティ構文を使用すれば読み取り書き込みできる
public record Product
{
    public required string Name {get; init;}
    public decimal Price {get; set;}
}