// 各エントリから空白をトリミングする

string numerals = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";

// TrimEntriesで各要素の先頭と末尾の空白を削除する
string[] trimmed = numerals.Split(',', StringSplitOptions.TrimEntries);

Console.WriteLine("Trimmed entries:");
foreach (var word in trimmed)
{
    Console.WriteLine($"<{word}>");
}

// Noneの場合は空白をそのまま残す
string[] untrimmed = numerals.Split(',', StringSplitOptions.None);
Console.WriteLine("Untrimmed entries:");
foreach (var word in untrimmed)
{
    Console.WriteLine($"<{word}>");
}