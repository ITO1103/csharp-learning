// 既知のテキストを置き換える

string source = "The mountains are behind the clouds today.";
string updated = source.Replace("mountains", "peaks"); // Replaceで前者の文字列を後者の文字列に置き換える(置換だが，新しい文字列を作成している)

Console.WriteLine(source);
Console.WriteLine(updated);

source = "The mountains are behind the clouds today.";
updated = source.Replace(' ', '_'); // 全ての空白を_に置き換える

Console.WriteLine(updated);
