// テキストの位置を見つける

string factMessage = "Extension methods have all the capabilities of regular static methods.";

Console.WriteLine($"\"{factMessage}\"");


// 最初に出てくる"methods"の位置を取得
// +"methods".Lengthで最初の"methods"の直後の位置にする
int first = factMessage.IndexOf("methods") + "methods".Length;

// 最後に出てくる"methods"の開始位置を取得
int last = factMessage.LastIndexOf("methods");

// 最初のmethodsの直後から，最後のmethodsの直前までを取り出す
string between = factMessage.Substring(first, last - first);

Console.WriteLine($"""Substring between "methods" and "methods": '{between}'""");