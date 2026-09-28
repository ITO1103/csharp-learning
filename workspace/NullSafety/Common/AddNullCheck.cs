// null チェックを追加する

// Console.WriteLine(LengthOfMessageUnsafe(null)); nullだと警告
Console.WriteLine(LengthOfMessageUnsafe("Hello"));
Console.WriteLine(DereferenceFixed(null));
Console.WriteLine(NullOperatorsFix(null));

// nullチェックなしでLengthにアクセスすると警告が出る
static int LengthOfMessageUnsafe(string? message)
{
    return message.Length;
}

// nullの場合は先にreturnする
// ここを通過した後はmessageがnullではないとコンパイラが判断する
static int DereferenceFixed(string? message)
{
    if (message is null)
    {
        return 0;
    }

    return message.Length;
}

// ?.でnullではない場合だけLengthにアクセスし，nullなら??で0を使う
static int NullOperatorsFix(string? message)
{
    int length = message?.Length ?? 0;

    // nullではなく，Lengthが0より大きい場合だけ一致する
    if (message is {Length: > 0})
    {
        length = message.Length;
    }

    return length;
}