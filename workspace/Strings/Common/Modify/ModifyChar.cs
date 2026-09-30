// 個々の文字を変更する

string phrase = "The quick brown fox jumps over the fence.";

// stringは不変なので，内容を変更可能なSpan<char>を用意
Span<char> characters = stackalloc char[phrase.Length];

// コピー
phrase.CopyTo(characters);

// "fox"が始まる位置を探す
int index = phrase.IndexOf("fox"); // "fox"が見つかった場合
if (index != -1)
{   // "fox"の3文字を"cat"に書き換える
    characters[index] = 'c';
    characters[index + 1] = 'a';
    characters[index + 2] = 't';
}

// 変更したSpan<char>から新しいstringを作成する
string updated = new string(characters);
Console.WriteLine(updated);