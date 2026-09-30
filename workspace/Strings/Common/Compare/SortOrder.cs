// 並べ替え順序を比較する

string first = "Avocado";
string second = "Banana";

// Compareで文字列の並び順を比較する (負の数, 0 , 正の数が帰ってくる)
int order = string.Compare(first, second, StringComparison.Ordinal);
Console.WriteLine(order < 0
    ? $"'{first}' sorts before '{second}'."
    : $"'{first}' sorts at or after '{second}'.");