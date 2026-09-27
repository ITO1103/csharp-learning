// ! で警告を上書きします

NullForgiving();

static void NullForgiving()
{
    // 戻り値の型がstring?なのでコンパイラはnullの可能性があると判断
    string? maybeName = LookUpName("ada");

    // !を付けることで「これはnullではない」とコンパイラに伝える
    int length = maybeName!.Length;

    Console.WriteLine(length);
}

// 該当するidなら文字列を返し，それ以外はnullを返す
static string? LookUpName(string id) => id switch
{
    "ada" => "Ada Lovelace",
    _ => null,
};