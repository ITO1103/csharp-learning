// 文字列の等価性

string left = "hello";

// Concatで文字列結合
string right = string.Concat("hel", "lo");

// stringは参照ではなく文字列の内容(値)で比較される
Console.WriteLine(left == right);

// Ordinalで文字列をそのままの文字コード順に比較する
Console.WriteLine(left.Equals(right, StringComparison.Ordinal));