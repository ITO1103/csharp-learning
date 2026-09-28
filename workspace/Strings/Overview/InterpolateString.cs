// 補間文字列

string name = "Ada";
int score = 92;

// $を付けると{}の中に変数や式を埋め込める
string greeting = $"Hello, {name}! Your score is {score}.";

// ,10で10文字分の幅を取って右寄せ
string formatted = $"pi = {Math.PI:F3}, padded = |{name,10}|";

// $"""で複数行の文字列にも値を埋め込める
string report = $"""
    Report for {name}
    -----------------
    Score : {score}
    Grade : {(score >= 90 ? "A" : "B")}
    """;

Console.WriteLine(greeting);
Console.WriteLine(formatted);
Console.WriteLine(report);