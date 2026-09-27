// null 条件付きインデクサー アクセス ?[]

// ?[]を使うと配列やコレクションがnullではない場合だけ要素にアクセスする
string[]? tags = null;

// tagsがnullなのでtags[0]にはアクセスせずfirstはnullになる
string? first = tags?[0];

Console.WriteLine(first ?? "(none)");

tags = ["csharp", "dotnet", "nullable"];

// nullではないので0番目の要素を取得する
Console.WriteLine(tags?[0]);