// レコードの種類を作成する

Point pt3 = new Point(1, 1);
var pt4 = pt3 with {Y = 10}; // withで新しいオブジェクトを作成
Console.WriteLine($"The two points are {pt3} and {pt4}");

double slopeResult = pt4.Slope();
Console.WriteLine($"The slope of {pt4} is {slopeResult}");

structPoint pt5 = new structPoint(1, 1);
var pt6 = pt5 with {Y = 10};
Console.WriteLine($"The two points are {pt5} and {pt6}");

double structSlopeResult = pt6.StructSlope();
Console.WriteLine($"The slope of {pt6} is {structSlopeResult}");



// record : 複数の値をまとめた，名前付きで再利用可能な型を定義できる
// だけでなく，処理も追加することができる関数
// トップレベルステートメントなので型定義を実行コードより後に書く
// 参照型 : 基本的にnewしない限り同じオブジェクトへ参照する
// record機能を持ったclass
public record Point(int X, int Y)
{
    public double Slope() => (double)Y / (double)X;
}


// record structは値型
// record機能を持ったstruct
public record struct structPoint(int X, int Y)
{
    public double StructSlope() => (double)Y / (double)X;
}