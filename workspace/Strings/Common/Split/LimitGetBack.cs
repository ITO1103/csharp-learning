// 返される部分文字列の数を制限する

string phrase = "The quick brown fox jumps over the lazy dog.";

// 最大4個の要素に分割する(4個目には残りの文字列がすべて入る)
string[] words = phrase.Split(' ', 4, StringSplitOptions.None);

foreach (var word in words)
{
    Console.WriteLine($"<{word}>");
}