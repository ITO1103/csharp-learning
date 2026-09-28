// 1 行の生文字列

// raw stringは3つ以上の"で囲む(中の"や\はそのまま文字として扱われる)
string message = """She said "hi" and left.\""";

// 正規表現の\もエスケープせずに書ける
string regex = """\d{3}-\d{4}""";

Console.WriteLine(message);
Console.WriteLine(regex);