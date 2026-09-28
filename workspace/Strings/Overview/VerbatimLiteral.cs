// 逐語文字列リテラル

// @を付けると\をそのまま文字として扱える (Windowsのパスで便利)
string winPath = @"C:\src\app\readme.md";

// 正規表現でも\をエスケープしなくてよい
string pattern = @"\d{3}-\d{4}";

Console.WriteLine(winPath);
Console.WriteLine(pattern);