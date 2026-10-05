// 短絡評価の実際

string? text = null;

// textがnullなら&&の右側は評価されないので，text.Lengthにはアクセスしない
bool hasContent = text != null && text.Length > 0;
Console.WriteLine(hasContent);

text = "hello";

// textがnullではないので，右側のtext.Length > 0も評価する
hasContent = text != null && text.Length > 0;
Console.WriteLine(hasContent);

string word = "hello";

// 左側がtrueになった時点で||全体がtrueになるので，右側は評価されない
bool anyMatch = word.StartsWith("h") || word.StartsWith("x");
Console.WriteLine(anyMatch);

string? maybeNull = null;

// maybeNullがnullならLengthにはアクセスせずnullを返す
int? length = maybeNull?.Length;
Console.WriteLine(length.HasValue);