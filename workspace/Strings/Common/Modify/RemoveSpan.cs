// 一定範囲の文字を削除する

string source = "Many mountains are behind many clouds today.";
string toRemove = "many ";

// sourceの中からtoRemoveが最初に出てくる位置を探す(見つからなければ-1)
int index = source.IndexOf(toRemove);
string result = index >= 0
    ? source.Remove(index, toRemove.Length) // 見つかった場合は，その位置からtoRemoveの文字数分を削除する
    : source; // 見つからなければ何もしない

Console.WriteLine(result);