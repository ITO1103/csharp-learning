// 文字列を解析して値を反復処理する

var parsed = Enum.Parse<Season>("Winter"); // 文字列をenum値に変換する
Console.WriteLine(parsed);

// 変換できるか試し成功したらout引数に結果を入れる
if(Enum.TryParse<Season>("Monsoon", out var unknown))
{
    Console.WriteLine(unknown);
}
else
{
    Console.WriteLine("'Monsoon' is not a valid Season");
}

// Enum.GetValues: enumに定義されている値をすべて取得する
foreach (var season in Enum.GetValues<Season>())
{
    Console.WriteLine($"{season} = {(int)season}");
}

enum Season
{
    Spring, // 0
    Summer, // 1
    Autumn, // 2
    Winter // 3
}