// スライスにパターンを適用する

Console.WriteLine(HasContent(["BEGIN", "Hello", "END"])); 
Console.WriteLine(HasContent(["BEGIN", "A", "B", "END"]));
Console.WriteLine(HasContent(["BEGIN", "END"]));
static bool HasContent(string[] entries) =>
    entries is ["BEGIN", .. { Length: > 0 }, "END"];  // BEGINとENDの間に1個以上の要素があればtrue