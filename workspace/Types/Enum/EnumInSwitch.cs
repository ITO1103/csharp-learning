// switch 式で列挙型を使用する

var today = Season.Autumn;
Console.WriteLine(DescribeSeason(today));

// Enumの値をswitch式で使える
static string DescribeSeason(Season season) => season switch
{
    Season.Spring => "Flowers bloom and temperatures rise.",
    Season.Summer => "Long days and warm weather.",
    Season.Autumn => "Leaves change color and fall.",
    Season.Winter => "Short days and cold temperatures.",
    _ => throw new ArgumentOutOfRangeException(nameof(season))
};

enum Season
{
    Spring, // 0
    Summer, // 1
    Autumn, // 2
    Winter // 3
}