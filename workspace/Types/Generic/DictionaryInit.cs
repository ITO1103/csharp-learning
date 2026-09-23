// ディクショナリの初期化

// {}じゃなくて[]←でも初期化できる
Dictionary<string, int> scores = new()
{
    ["Alice"] = 95,
    ["Bob"] = 87,
    ["Carol"] = 92
};

foreach(var (name, score) in scores)
{
    Console.WriteLine($"{name}: {score}");
}

Dictionary<string, int> defaults = new()
{
    ["Timeout"] = 30,
    ["Retries"] = 3
};
Dictionary<string, int> overrides = new()
{
    ["Timeout"] = 60
};

// ディクショナリをマージするにはコピーしてオーバーライド(上書き)する
Dictionary<string, int> config = new(defaults);
foreach (var (key, value) in overrides)
{
    config[key] = value;
}

Console.WriteLine($"Timeout: {config["Timeout"]}");
Console.WriteLine($"Retries: {config["Retries"]}");