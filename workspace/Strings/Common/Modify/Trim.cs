// 空白をトリミングする

string source = "    I'm wider than I need to be.      ";
// 先頭と末尾の空白を取り除く
Console.WriteLine($"<{source.Trim()}>");
// 先頭の空白を取り除く
Console.WriteLine($"<{source.TrimStart()}>");
// 末尾の空白を取り除く
Console.WriteLine($"<{source.TrimEnd()}>");
