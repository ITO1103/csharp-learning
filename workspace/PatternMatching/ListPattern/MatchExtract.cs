// ぴったり一致する形に合わせる


Console.WriteLine(IsHeader(["Name", "Score"]));
Console.WriteLine(IsHeader(["Name", "Age"]));
Console.WriteLine(IsHeader(["Name", "Score", "Age"]));

// 配列の要素数，値，並び順が完全に一致するか確認する
static bool IsHeader(string[] columns) =>
    columns is ["Name", "Score"]; // 要素数が2個で"Name", "Score"の順ならtrue