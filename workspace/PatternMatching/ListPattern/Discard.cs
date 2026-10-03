// 破棄を使用して任意の要素値と一致させる

List<string> order1 = ["Alice", "Bob", "Carol"];
List<string> order2 = ["Alice", "Bob"];

Console.WriteLine(GetAnnouncements(order1));
Console.WriteLine(GetAnnouncements(order2));


static string GetAnnouncements(List<string> finishingOrder) =>
    finishingOrder switch
    {
        // 1位をwinner，3位をthirdPlaceとして取得する (2位は_で無視する)
        [var winner, _, var thirdPlace] =>
            $"Winner: {winner}; third place: {thirdPlace}",
        _ => "A complete three-runner result isn't available"
    };