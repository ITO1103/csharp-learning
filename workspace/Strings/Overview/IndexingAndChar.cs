// インデックス作成と char

string word = "café";

// 文字数
Console.WriteLine(word.Length);

// 0番目の文字をcharとして取得
Console.WriteLine(word[0]);

// 1文字ずつ取り出す
foreach (char c in word)
{
    Console.Write($"{c} ");
}

Console.WriteLine();//改行だけしたい場合は\nとか無しでそのまま実行すれば改行されるの初耳