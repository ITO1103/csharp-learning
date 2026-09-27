// null 条件付き代入 (C# 14)
// C#14以降は割当ターゲットとして?.と?[]を使用可能

AppConfig? config = new AppConfig();

// configがnullではない場合だけThemeに代入する
config?.Theme = "dark";

Console.WriteLine(config?.Theme);

AppConfig? missing = null;

// missingがnullなので代入されない
missing?.Theme = "light";

// missingがnullなので"(no config)"を表示する
Console.WriteLine(missing?.Theme ?? "(no config)");

public sealed class AppConfig
{
    public string? Theme {get; set;}
}