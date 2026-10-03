// 別の条件に対して when ガードを使用する

Console.WriteLine(GetHeatWarning(40, true));
Console.WriteLine(GetHeatWarning(40, false));
Console.WriteLine(GetHeatWarning(25, true));

static string GetHeatWarning(int temperature, bool isOutdoors) =>
    temperature switch
    {
        // temperatureが35より大きくisOutdoorsがtrueの場合
        > 35 when isOutdoors => "High heat outdoors",

        // temperatureが35より大きい場合
        > 35 => "High heat",

        // それ以外
        _ => "No heat warning"
    };