// タプルの分解

var point = (X: 3, Y: 7);

// varで簡単に分解
var (x, y) = point;
Console.WriteLine($"x={x}, y={y}");

// 型を明示的に指定して分解
(int px, int py) = point;
Console.WriteLine($"px={px}, py={py}");

// 既存の変数に分解
int a, b;
(a, b) = point;
Console.WriteLine($"a={a}, b={b}");

// returnを直接分解する
List<double> data = [10.0, 20.0, 30.0];
var (min, max, avg) = ComputeStats(data);
Console.WriteLine($"Min: {min}, Max: {max}, Avg: {avg}");


List<(string Name, int Score)> results =
[
    ("Alice", 92),
    ("Bob", 87),
    ("Carol", 95)
];
// foreachでも分解可能
foreach (var (name, score) in results)
{
    Console.WriteLine($"{name}: {score}");
}

// _を使用することでその要素を破棄できる
List<double> values = [5.0, 10.0, 15.0];
var (_, max, _) = ComputeStats(values);
Console.WriteLine($"Only need the max: {max}");


static (double Minimum, double Maximum, double Average) ComputeStats(List<double> values)
{
    var min = values.Min();
    var max = values.Max();
    var avg = values.Average();
    return (min, max, avg); // タプルだから複数返せる
}