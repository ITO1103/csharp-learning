// 注釈を調整する

AssignmentWarning();
AssignmentFixed();

// Lookupはnullを返す可能性があるのにstringで受けているので警告
static void AssignmentWarning()
{
    string name = Lookup("nobody");
    Console.WriteLine(name);
}


// nullを返す可能性があるのでstring?で受け取る
static void AssignmentFixed()
{
    string? name = Lookup("somebody");

    // nullではない場合だけ使用する
    if (name is not null)
    {
        Console.WriteLine(name);
    }
}

// 該当する名前があれば文字列を返し，なければnullを返す
static string? Lookup(string id)
{
    return id switch
    {
        "somebody" => "Alice",
        "bob" => "Bob",
        _ => null
    };
}