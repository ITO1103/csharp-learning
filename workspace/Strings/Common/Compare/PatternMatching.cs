// パターン マッチングで定数を is または switch と比較する

string status = "Ready";

if (status is "Ready") // 右側が定数の場合はisで比較できる
{
    Console.WriteLine("The system is ready.");
}

foreach (string heading in new[] { "North", "South", "East", "West", "NE" })
{

    string instruction = heading switch // headingの値と一致する文字列を順番に探す
    {
        "North" => "Travel due North for 10 km.",
        "South" => "Travel due South for 10 km.",
        "East" => "Travel due East for 10 km.",
        "West" => "Travel due West for 10 km.",
        _ => $"Unknown heading: {heading}.", // どれにも一致しなかった場合
    };
    Console.WriteLine(instruction);
}