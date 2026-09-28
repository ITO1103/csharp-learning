// 通常のリテラルとエスケープシーケンス

// \tでタブ
string tabbed = "name:\tAda";

// \nで改行
string twoLines = "line 1\nline 2";

// \"で"を文字として入れる
string quoted = "She said \"hi\".";

// \\で\を文字として入れる
string path = "C:\\src\\app";

Console.WriteLine(tabbed);
Console.WriteLine(twoLines);
Console.WriteLine(quoted);
Console.WriteLine(path);

// \n: 改行
// \t: タブ
// \": リテラル引用符
// \\: リテラルバックスラッシュ
// \0: null文字
// \uXXXX: Unicodeエスケープ

// C# 13以降は\eでESC文字を表せる(ANSIエスケープシーケンスなどで使用する)
string esc = "\e[31mError\e[0m: file missing";

Console.WriteLine(esc);

Console.WriteLine((int)'\e');