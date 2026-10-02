// 名前と位置を比較する

var reading1 = new WeatherReading(32, 80);
var reading2 = new WeatherReading(25, 80);

Console.WriteLine(IsHotAndHumid(reading1));
Console.WriteLine(IsHotAndHumid(reading2));

// プロパティ名を指定して条件を確認する
static bool IsHotAndHumid(WeatherReading reading) =>
    // TemperatureCが30より大きく，HumidityPercentが70より大きいか
    reading is { TemperatureC: > 30, HumidityPercent: > 70 };

// タプルの位置を使って値の組み合わせを確認する
static string GetCrossingInstruction(
    PedestrianSignal signal, bool crossingIsClear) =>
    (signal, crossingIsClear) switch
    {
        // 1番目がWalk，2番目がtrueの場合
        (PedestrianSignal.Walk, true) => "Cross now",
        // 1番目がWalk，2番目がfalseの場合
        (PedestrianSignal.Walk, false) => "Wait for the crossing to clear",
        // 上記以外
        _ => "Wait for the walk signal"
    };

// 気温と湿度を持つrecord
sealed record WeatherReading(int TemperatureC, int HumidityPercent);

// 歩行者用信号の状態
enum PedestrianSignal
{
    Stop,
    Walk
}