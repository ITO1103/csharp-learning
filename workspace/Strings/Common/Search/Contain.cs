// 文字列にテキストが含まれているかどうかを確認する

string factMessage = "Extension methods have all the capabilities of regular static methods.";

// Containsで指定した文字列が含まれているか確認(デフォルトでは大文字小文字を区別)
bool containsSearchResult = factMessage.Contains("extension");
Console.WriteLine($"""Contains "extension"? {containsSearchResult}""");

// StartsWithで指定した文字列から始まっているか確認(CurrentCultureIgnoreCaseで大文字小文字を無視)
bool ignoreCaseSearchResult = factMessage.StartsWith("extension", StringComparison.CurrentCultureIgnoreCase);
Console.WriteLine($"""Starts with "extension"? {ignoreCaseSearchResult} (ignoring case)""");

// EndsWithで指定した文字列で終わっているか確認
bool endsWithSearchResult = factMessage.EndsWith(".", StringComparison.Ordinal);
Console.WriteLine($"Ends with '.'? {endsWithSearchResult}");

string path = "/usr/local/bin";
bool hasSlash = path.Contains('/'); // 1文字だけの場合はcharをそのままContainsに渡せる(''はcharで""はstringなので注意)
Console.WriteLine($"Path contains '/': {hasSlash}");