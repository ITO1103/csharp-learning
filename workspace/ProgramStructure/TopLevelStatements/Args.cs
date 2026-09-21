// args

// 最上位レベルステートメントはargs変数でコマンドライン引数にアクセス可能
if (args.Length > 0)
{
    foreach (var arg in args)
    {
        Console.WriteLine($"Argument={arg}");
    }
}
else // コマンドライン引数がない場合
{
    Console.WriteLine("No arguments");
}