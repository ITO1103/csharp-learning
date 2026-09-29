// 文字列補間を使用する

string name = "Alex";
string day = "Monday";

// 文字列補完を使用可能．+より読みやすいのでオススメ
string greeting = $"Hello {name}. Today is {day}.";
Console.WriteLine(greeting);