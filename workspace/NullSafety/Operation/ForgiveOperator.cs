// null を許す演算子 !

string? name = FindUser("alice");

// !を付けて「ここはnullではない」とコンパイラに伝える
int length = name!.Length;

Console.WriteLine(length);

// ユーザー名が見つかれば文字列を返し，見つからなければnullを返す
static string? FindUser(string id)
{
    return id switch
    {
        "alice" => "Alice",
        "bob" => "Bob",
        _ => null
    };
}