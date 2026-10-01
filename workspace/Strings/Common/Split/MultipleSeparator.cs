// 複数の区切り文字で分割する

char[] delimiters = [' ', ',', '.', ':', '\t']; // これらを区切り文字として使用

string text = "one\ttwo three:four,five six seven";
Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(delimiters); // 区切る
Console.WriteLine($"{words.Length} words in text:");

foreach (var word in words)
{
    Console.WriteLine($"<{word}>");
}

text = "one\ttwo :,five six seven";

words = text.Split(delimiters); // 区切る(区切り文字が連続する場合は空になる)
Console.WriteLine($"{words.Length} words in text:");

foreach (var word in words)
{
    Console.WriteLine($"<{word}>");
}