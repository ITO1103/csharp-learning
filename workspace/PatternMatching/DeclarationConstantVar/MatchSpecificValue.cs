// 特定の値を定数パターンと一致させる

Command test = Command.Start;
Console.WriteLine(GetCommandMessage(test));

Console.WriteLine(HasText("TEXT"));
Console.WriteLine(HasText(null));

static string GetCommandMessage(Command command) => // そもそも引数はCommand型で制限
    command switch // Command型の値がどの定数と一致するか確認
    {
        Command.Start => "Starting",
        Command.Stop => "Stopping",
        Command.Pause => "Pausing",
        _ => "Unknown command"
    };

static bool HasText(string? text) => text is not null; // is nullでnullかどうかを検証

enum Command // 「Commandは列挙型であり〜」
{
    Start,
    Stop,
    Pause
}


