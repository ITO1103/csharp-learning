// 引用符とバックスラッシュを含むリテラル

// 通常の文字列では"や\をエスケープする必要がある
string regular = "{ \"name\": \"Ada\", \"path\": \"C:\\\\src\" }";

// @を付けると\はそのまま書けるが，"は""と書く必要がある
string verbatim = @"{ ""name"": ""Ada"", ""path"": ""C:\\src"" }";

// raw stringでは"も\もそのまま書ける
string raw = """{ "name": "Ada", "path": "C:\\src" }""";

// 値で比較するので全て同じになる
Console.WriteLine(regular == raw);
Console.WriteLine(verbatim == raw);