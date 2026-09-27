// null 条件付きメンバー アクセス ?.

string? name = null;

// ?.を使うとnullではない場合だけメンバーにアクセスする
int? len = name?.Length;

Console.WriteLine(len.HasValue);

name = "C#";

// nameがnullではないのでLengthにアクセスする
Console.WriteLine(name?.Length);


string? input = null;

// 途中でnullになった場合はそれ以降の処理を行わない
string? upper = input?.Trim()?.ToUpperInvariant();

Console.WriteLine(upper ?? "(none)");

input = "  hello  ";

// nullではないのでTrim()とToUpperInvariant()が順番に実行される
Console.WriteLine(input?.Trim()?.ToUpperInvariant());