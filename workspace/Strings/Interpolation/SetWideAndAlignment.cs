// フィールドの幅と配置を設定する

var titles = new Dictionary<string, string>()
{
    ["Doylem Arthur Conan"] = "Hound of the Baskervilles, The",
    ["London, Jack"] = "Call of the Wild, The",
    ["Shakespeare, William"] = "Tempest, The"
};

Console.WriteLine("Auther and Title List");
Console.WriteLine();
Console.WriteLine($"|{"Author",-25}|{"Title",30}|"); // 最小フィールド幅を設定(正の幅は右揃え，負の幅は左揃え)

foreach (var title in titles)
{
    Console.WriteLine($"|{title.Key,-25}|{title.Value,30}|");
}

const int NameAlignment = -9;
const int ValueAlignment = 7;
double a = 3;
double b = 4;
Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
Console.WriteLine($"|{"Arithmetic",NameAlignment}|{0.5 * (a + b),ValueAlignment:F3}|"); // 配置と書式指定を同時に設定する場合，(,配置:書式設定)の順
Console.WriteLine($"|{"Geometric",NameAlignment}|{Math.Sqrt(a * b),ValueAlignment:F3}|");
Console.WriteLine($"|{"Harmonic",NameAlignment}|{2 / (1 / a + 1 / b),ValueAlignment:F3}|");