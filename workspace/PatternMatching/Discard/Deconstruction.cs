// 脱構築に関する宣言

ShowForecast();

static void ShowForecast()
{
    // CityとHighだけ取得しLowとRainChanceは_で無視
    var (city, high, _, _) = GetForecast();
    Console.WriteLine($"{city}: high {high}°C");

    static (string City, int High, int Low, int RainChance) GetForecast() =>
        ("Portland", 18, 9, 40);
}