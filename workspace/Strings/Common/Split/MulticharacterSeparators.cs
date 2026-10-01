// マルチ文字区切り記号で分割する

string[] separators = ["<<", "..."];

string text = "one<<two......three<four";
Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries); // RemoveEmptyEntriesで空の要素を削除する
// ...が連続しているのでそのままだと空になる可能性があるので↑で除外している？
Console.WriteLine($"{words.Length} substrings in text:");

foreach (var word in words)
{
    Console.WriteLine(word);
}
