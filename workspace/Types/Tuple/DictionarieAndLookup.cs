// 辞書や検索におけるタプル

// タプルはディクショナリーのデータとしても機能する
// これすごい便利そう
var sizeChart = new Dictionary<string, (int Min, int Max)>
{
    ["Small"] = (0, 50),
    ["Medium"] = (51, 100),
    ["Large"] = (101, 200)
};

// ディクショナリーの中身を検索で取り出す
if (sizeChart.TryGetValue("Medium", out var range))
{
    Console.WriteLine($"Medium: {range.Min}–{range.Max}");
}

// ディクショナリーのキーとしてもタプルを使うことができる
// 可能性しかなくて感動している
var grid = new Dictionary<(int Row, int Column), string>
{
    [(0, 0)] = "Origin",
    [(1, 3)] = "Sensor A",
    [(2, 5)] = "Sensor B"
};

// 検索で取り出す
var target = (Row: 1, Column: 3);
if (grid.TryGetValue(target, out var label))
{
    Console.WriteLine($"({target.Row}, {target.Column}): {label}");
}