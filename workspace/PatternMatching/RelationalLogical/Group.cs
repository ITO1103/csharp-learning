// 括弧を使ってパターンをグループ化する

Console.WriteLine(IsAcceptedPriority(1));
Console.WriteLine(IsAcceptedPriority(3));
Console.WriteLine(IsAcceptedPriority(5));
Console.WriteLine(IsAcceptedPriority(9));

static bool IsAcceptedPriority(int priority) =>
    // 1以上3以下，または9の場合にtrue
    priority is (>= 1 and <= 3) or 9;