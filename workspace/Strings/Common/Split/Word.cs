// 文字列を単語に分割する

string phrase = "The quick brown fox jumps over the lazy dog.";
string[] words = phrase.Split(' '); // 空白区切りで配列に単語を入れていく

foreach (var word in words) // 配列でループ
{
    Console.WriteLine($"<{word}>");
}

for (int i = 0; i < words.Length; i++) // インデックスでループ
{
    Console.WriteLine($"Index {i}: <{words[i]}>");
}

phrase = "The quick brown    fox     jumps over the lazy dog.";
words = phrase.Split(' '); // 連続する空白の場合は空白ごとが配列に入る

foreach (var word in words)
{
    Console.WriteLine($"<{word}>");
}