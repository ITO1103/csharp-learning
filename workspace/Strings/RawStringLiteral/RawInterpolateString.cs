// 未加工の補間文字列

string name = "Ada";
int score = 95;

// $を付けるとraw stringでも変数を埋め込める
string report = $"""
    Player:  {name}
    Score:   {score}
    Updated: {DateTime.UtcNow:yyyy-MM-dd}
    """;

Console.WriteLine(report);