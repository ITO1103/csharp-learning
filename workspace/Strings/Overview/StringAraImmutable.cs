// 文字列は不変です
using System.Text;

// stringは作成後に中身そのものを変更できない(代入しても参照先が変わるだけで元は変わらない)
string greeting = "hello";

// ToUpperInvariant()は元の文字列を書き換えず，新しい文字列を返す
string shouted = greeting.ToUpperInvariant();

// 元の文字列はそのまま
Console.WriteLine(greeting);

// 新しく作られた文字列
Console.WriteLine(shouted);

// StringBuilderは中身を変更できるので文字列を何度も追加する際に便利
var builder = new StringBuilder();
for (int i = 1; i <= 3; i++)
{
    // Appendで文字列を追加していく
    builder.Append("item ").Append(i).Append(';');
}
// 最後にstringに変換する
string result = builder.ToString();
Console.WriteLine(result);