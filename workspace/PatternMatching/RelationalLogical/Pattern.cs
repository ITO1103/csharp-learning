// パターン入力

Console.WriteLine(ClassifyTemperature(-5));
Console.WriteLine(ClassifyTemperature(20));
Console.WriteLine(ClassifyTemperature(5));
Console.WriteLine(ClassifyTemperature(35));

static string ClassifyTemperature(int temperature) =>
    temperature switch
    {
        // 0未満の場合
        < 0 => "Below freezing",

        // 18以上かつ24以下の場合
        >= 18 and <= 24 => "Comfortable",

        // 0以上10未満，または30より大きい場合
        (>= 0 and < 10) or > 30 => "Far outside the comfortable range",
        // それ以外
        _ => "Cool or warm"
    };