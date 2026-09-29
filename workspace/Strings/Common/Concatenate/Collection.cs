// 文字列のコレクションを結合する

string[] words = ["The", "quick", "brown", "fox"];

// Concatで区切り記号なしで結合
string runTogether = string.Concat(words);
Console.WriteLine(runTogether);

// Joinで区切り記号ありで結合(今回は空白)
string sentence = string.Join(' ', words);
Console.WriteLine(sentence);