// 特定のカルチャを使用して書式設定する
using System.Globalization;

CultureInfo[] cultures =
[
    CultureInfo.GetCultureInfo("en-US"), // アメリカ
    CultureInfo.GetCultureInfo("en-GB"), // イギリス
    CultureInfo.GetCultureInfo("nl-NL"), // オランダ
    CultureInfo.InvariantCulture // 中立的なカルチャー情報
];
var date = new DateTime(2026, 5, 21, 12, 35, 31);
var number = 31_415_926.536;
foreach (var culture in cultures) // それぞれのフォーマット(カルチャ)で日時と数値を出力
{
    var cultureSpecificMessage = string.Create(culture, $"{date,23}{number,20:N3}");
    Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
}

var timestamp = new DateTime(2026, 5, 21, 15, 46, 24);
// 中立的なフォーマット = インバリアント出力 (ログ、ファイル形式、コンピューターが読み取り可能なデータ) らしい
string message = string.Create(CultureInfo.InvariantCulture, $"Date and time in invariant culture: {timestamp}");
Console.WriteLine(message);